namespace Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Skeleton.Interfaces;
    using System;

    [TestClass]
    public class DummyTests
    {
        private const int DummyHealth = 15;
        private const int DummyExperience = 10;
        private const int AxeDamage = 5;
        private const int AxeDurability = 5;

        private ITarget dummy = new Dummy(DummyHealth, DummyExperience);

        [TestMethod]
        public void DummyShouldLoseHealthWhenAttacked()
        {
            //Arrange
            IWeapon axe = new Axe(AxeDamage, AxeDurability);

            //Act
            axe.Attack(dummy);

            //Assert
            int expectedHealth = DummyHealth - AxeDamage;
            Assert.AreEqual(expectedHealth, dummy.Health, "Dummy doesn't lose health when attacked.");
        }

        [TestMethod]
        public void DeadDummyShouldThrowExceptionIfDeadWhenAttacked()
        {
            //Arrange
            IWeapon axe = new Axe(AxeDamage, AxeDurability);
            string exceptionMessage = string.Empty;

            //Act
            try
            {
                while (!dummy.IsDead())
                {
                    axe.Attack(dummy);
                }

                axe.Attack(dummy);
            }
            catch (InvalidOperationException ioe)
            {
                exceptionMessage = ioe.Message;
            }

            //Assert
            Assert.AreEqual("Dummy is dead.", exceptionMessage, "Dummy is attacked although dead.");
        }

        [TestMethod]
        public void DeadDummyShouldGiveExperiencePoints()
        {
            //Arrange
            Hero hero = new Hero("Hero");

            //Act
            hero.Attack(dummy);
            hero.Attack(dummy);

            //Assert
            int expectedExperience = DummyExperience;
            Assert.AreEqual(expectedExperience, hero.Experience, "Dead dummy doesn't give experience.");
        }

        [TestMethod]
        public void AliveDummyShouldNotGiveExperiencePoints()
        {
            //Arrange
            Hero hero = new Hero("Hero");

            //Act
            hero.Attack(dummy);

            //Assert
            int expectedExperience = 0;
            Assert.AreEqual(expectedExperience, hero.Experience, "Alive dummy gives experience.");
        }
    }
}

namespace Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class AxeTests
    {
        private const int DummyHealth = 15;
        private const int DummyExperience = 10;
        private const int AxeDamage = 5;
        private const int AxeDurability = 5;

        private Axe axe = new Axe(AxeDamage, AxeDurability);
        private Dummy dummy = new Dummy(DummyHealth, DummyExperience);

        [TestMethod]
        public void AxeShouldLoseDurabilityAfterAttack()
        {
            //Arrange

            //Act
            axe.Attack(dummy);

            //Assert
            int expectedDurability = AxeDurability - 1;
            Assert.AreEqual(expectedDurability, axe.DurabilityPoints, "Axe durability doesn't lower after attack.");
        }

        [TestMethod]
        public void BrokenAxeShouldNotAttack()
        {
            //Arrange
            string exceptionMessage = string.Empty;

            //Act
            try
            {
                while (axe.DurabilityPoints != 0)
                {
                    axe.Attack(dummy);

                    if (dummy.IsDead())
                    {
                        dummy = new Dummy(DummyHealth, DummyExperience);
                    }
                }

                axe.Attack(dummy);
            }
            catch (InvalidOperationException ioe)
            {
                exceptionMessage = ioe.Message;
            }

            //Assert
            Assert.AreEqual("Axe is broken.", exceptionMessage, "Axe attacks although broken.");
        }
    }
}

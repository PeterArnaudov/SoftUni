namespace Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using Tests.FakeObjects;
    using Moq;
    using Skeleton.Interfaces;

    [TestClass]
    public class HeroTests
    {
        private const int TargetHealth = 10;
        private const int TargetExperience = 10;
        private const int WeaponDamage = 5;
        private const int WeaponDurability = 5;
        private const string HeroName = "HeroName";

        [TestMethod]
        public void HeroGainsExperienceAfterKillingTarget()
        {
            //Arrange
            FakeTarget fakeTarget = new FakeTarget(TargetHealth, TargetExperience);
            FakeWeapon fakeWeapon = new FakeWeapon(WeaponDamage, WeaponDurability);
            Hero hero = new Hero(HeroName, fakeWeapon);

            //Act
            while (!fakeTarget.IsDead())
            {
                hero.Attack(fakeTarget);
            }

            //Assert
            Assert.AreEqual(TargetExperience, hero.Experience, "Hero doesn't gain experience after killing a target.");
        }

        [TestMethod]
        public void HeroGainsExperienceAfterKillingTargetMoqTest()
        {
            //Arrange
            Mock<ITarget> fakeTarget = new Mock<ITarget>();
            fakeTarget.Setup(ft => ft.Health).Returns(TargetHealth);
            fakeTarget.Setup(ft => ft.IsDead()).Returns(true);
            fakeTarget.Setup(ft => ft.GiveExperience()).Returns(TargetExperience);

            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
            Hero hero = new Hero(HeroName, fakeWeapon.Object);

            //Act
            hero.Attack(fakeTarget.Object);

            //Assert
            Assert.AreEqual(TargetExperience, hero.Experience, "Hero doesn't gain experience after killing a target.");
        }
    }
}

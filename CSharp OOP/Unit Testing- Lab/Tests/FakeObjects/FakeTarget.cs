namespace Tests.FakeObjects
{
    using Skeleton.Interfaces;
    using System;

    public class FakeTarget : ITarget
    {
        private int health;
        private int experience;

        public FakeTarget(int health, int experience)
        {
            this.health = health;
            this.experience = experience;
        }

        public int Health => this.health;

        public void TakeAttack(int attackPoints)
        {
            if (this.IsDead())
            {
                throw new InvalidOperationException("Dummy is dead.");
            }

            this.health -= attackPoints;
        }

        public int GiveExperience()
        {
            if (!this.IsDead())
            {
                throw new InvalidOperationException("Target is not dead.");
            }

            return this.experience;
        }

        public bool IsDead()
        {
            return this.health <= 0;
        }
    }
}

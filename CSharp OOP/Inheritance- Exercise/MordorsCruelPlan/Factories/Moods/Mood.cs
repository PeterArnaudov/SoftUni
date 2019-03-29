namespace MordorsCruelPlan.Factories.Moods
{
    using System;

    public abstract class Mood
    {
        private int pointsOfHappiness;

        public Mood(int pointsOfHappiness)
        {
            this.pointsOfHappiness = pointsOfHappiness;
        }
    }
}

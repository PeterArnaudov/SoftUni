using MordorsCruelPlan.Factories;
using MordorsCruelPlan.Factories.Foods;
using MordorsCruelPlan.Factories.Moods;
using System;

namespace MordorsCruelPlan
{
    public class Wizard
    {
        private int pointsOfHappiness;

        public Wizard()
        {
            pointsOfHappiness = 0;
        }

        public void Eat(Food[] foods)
        {
            foreach (var item in foods)
            {
                pointsOfHappiness += item.PointsOfHappiness;
            }
        }

        public Mood GetMood()
        {
            return MoodFactory.GetMood(this.pointsOfHappiness);
        }

        public override string ToString()
        {
            return $"{this.pointsOfHappiness}{Environment.NewLine}{this.GetMood().GetType().Name}";
        }
    }
}

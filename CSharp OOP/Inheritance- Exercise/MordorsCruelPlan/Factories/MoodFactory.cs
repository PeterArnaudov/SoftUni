namespace MordorsCruelPlan.Factories
{
    using MordorsCruelPlan.Factories.Moods;
    using System;

    public static class MoodFactory
    {
        private const int SadMin = -5;
        private const int HappyMin = 1;
        private const int JavaScriptMin = 15;

        public static Mood GetMood(int pointsOfHappiness)
        {
            if (pointsOfHappiness < SadMin)
            {
                return new Angry(pointsOfHappiness);
            }
            else if (pointsOfHappiness >= SadMin && pointsOfHappiness < HappyMin)
            {
                return new Sad(pointsOfHappiness);
            }
            else if (pointsOfHappiness >= HappyMin && pointsOfHappiness < JavaScriptMin)
            {
                return new Happy(pointsOfHappiness);
            }
            else
            {
                return new JavaScript(pointsOfHappiness);
            }
        }
    }
}

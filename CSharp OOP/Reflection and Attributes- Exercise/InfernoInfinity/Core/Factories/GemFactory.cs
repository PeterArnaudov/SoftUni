namespace InfernoInfinity.Core.Factories
{
    using InfernoInfinity.Interfaces;
    using InfernoInfinity.Models.Gems;
    using System;

    public static class GemFactory
    {
        public static IGem CreateGem(string clarity, string gemType)
        {
            Type type = Type.GetType("InfernoInfinity.Models.Gems." + gemType);
            return (IGem)Activator.CreateInstance(type, clarity);
        }
    }
}

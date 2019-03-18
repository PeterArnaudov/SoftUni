namespace Logger.Layouts
{
    using System;

    public class SimpleLayout : ILayout
    {
        public string Format => "{0} - {1} - {2}";
    }
}

namespace Logger.Layouts
{
    using System;

    public class XmlLayout : ILayout
    {
        public string Format
        {
            get
            {
                return "<log>" + Environment.NewLine + "   <date>{0}</date>" + Environment.NewLine + "   <level>{1}</level>" + Environment.NewLine + "   <message>{2}</message>" + Environment.NewLine + "</log>";
            }
        }
    }
}

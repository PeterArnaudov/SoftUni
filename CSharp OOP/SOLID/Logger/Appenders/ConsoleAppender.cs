namespace Logger.Appenders
{
    using Logger.Enumerations;
    using Logger.Layouts;
    using System;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) 
            : base(layout)
        {
        }

        public override void Append(string date, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                Console.WriteLine(string.Format(this.Layout.Format, date, reportLevel, message));
                this.Messages++;
            }
        }
    }
}

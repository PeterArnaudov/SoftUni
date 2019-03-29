namespace Logger.Appenders
{
    using Logger.Enumerations;
    using Logger.Layouts;
    using System;

    public interface IAppender
    {
        ILayout Layout { get; }

        ReportLevel ReportLevel { get; set; }

        void Append(string date, ReportLevel reportLevel, string message);
    }
}

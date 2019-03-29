namespace Logger.Loggers
{
    using global::Logger.Appenders;
    using global::Logger.Enumerations;
    using System;
    using System.Text;

    public class Logger : ILogger
    {
        private IAppender[] appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        public IAppender[] Appenders => this.appenders;

        public void Info(string date, string message)
        {
            foreach (var appender in this.appenders)
            {
                appender.Append(date, ReportLevel.INFO, message);
            }
        }

        public void Warning(string date, string message)
        {
            foreach (var appender in this.appenders)
            {
                appender.Append(date, ReportLevel.WARNING, message);
            }
        }

        public void Error(string date, string message)
        {
            foreach (var appender in this.appenders)
            {
                appender.Append(date, ReportLevel.ERROR, message);
            }
        }

        public void Critical(string date, string message)
        {
            foreach (var appender in this.appenders)
            {
                appender.Append(date, ReportLevel.CRITICAL, message);
            }
        }

        public void Fatal(string date, string message)
        {
            foreach (var appender in this.appenders)
            {
                appender.Append(date, ReportLevel.FATAL, message);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Logger info");
            foreach (var appender in this.appenders)
            {
                sb.AppendLine(appender.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}

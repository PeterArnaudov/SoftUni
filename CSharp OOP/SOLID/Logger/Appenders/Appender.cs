namespace Logger.Appenders
{
    using System;
    using Logger.Layouts;
    using Logger.Enumerations;

    public abstract class Appender : IAppender
    {
        private ILayout layout;
        private int messages;
        private ReportLevel reportLevel;

        protected Appender(ILayout layout)
        {
            this.layout = layout;
            messages = 0;
            reportLevel = 0;
        }

        public ILayout Layout => this.layout;

        public int Messages
        {
            get => this.messages;

            set => this.messages = value;
        }

        public ReportLevel ReportLevel
        {
            get => this.reportLevel;

            set => this.reportLevel = value;
        }

        public abstract void Append(string date, ReportLevel reportLevel, string message);

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.ReportLevel}, Messages appended: {this.Messages}";
        }
    }
}

namespace Logger.Appenders
{
    using System;
    using Logger.Layouts;
    using Logger.Enumerations;
    using Logger.Files;

    public class FileAppender : Appender
    {
        private IFile file;

        public FileAppender(ILayout layout) 
            : base(layout)
        {
            this.File = new LogFile();
        }

        public IFile File
        {
            get => this.file;

            set => this.file = value;
        }

        public override void Append(string date, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                this.file.Write(string.Format(this.Layout.Format, date, reportLevel, message));
                this.Messages++; 
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", File size: {this.File.Size}";
        }
    }
}

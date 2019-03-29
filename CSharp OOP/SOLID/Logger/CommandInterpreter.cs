namespace Logger
{
    using System;
    using System.Collections.Generic;
    using Logger.Appenders;
    using Logger.Enumerations;
    using Logger.Files;
    using Logger.Layouts;
    using Logger.Loggers;

    public static class CommandInterpreter
    {
        public static void Interprete(int numberOfAppenders)
        {
            List<IAppender> appenders = new List<IAppender>();

            for (int i = 0; i < numberOfAppenders; i++)
            {
                string[] appenderInformation = Console.ReadLine().Split();

                ILayout layout = null;
                if (appenderInformation[1] == "SimpleLayout")
                {
                    layout = new SimpleLayout();
                }
                else if (appenderInformation[1] == "XmlLayout")
                {
                    layout = new XmlLayout();
                }

                IAppender appender = null;
                if (appenderInformation[0] == "ConsoleAppender")
                {
                    appender = new ConsoleAppender(layout);
                }
                else if (appenderInformation[0] == "FileAppender")
                {
                    appender = new FileAppender(layout);
                }

                if (appenderInformation.Length == 3)
                {
                    ReportLevel reportLevel = Enum.Parse<ReportLevel>(appenderInformation[2].ToUpper());
                    appender.ReportLevel = reportLevel;
                }

                appenders.Add(appender);
            }

            ILogger logger = new Logger(appenders.ToArray());

            string[] message = Console.ReadLine().Split('|');

            while (message[0] != "END")
            {
                foreach (var appender in logger.Appenders)
                {
                    appender.Append(message[1], Enum.Parse<ReportLevel>(message[0].ToUpper()), message[2]);
                }

                message = Console.ReadLine().Split('|');
            }

            Console.WriteLine(logger);
        }
    }
}

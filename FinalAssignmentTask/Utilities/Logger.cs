using log4net;
using log4net.Config;

namespace FinalAssignmentTask.Utilities
{
    public static class LoggerHelper
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LoggerHelper));

        static LoggerHelper()
        {
            BasicConfigurator.Configure();
        }

        public static void StartTestCase(string testCaseName)
        {
            log.Info("****************************************************************************************");
            log.Info($"*** Starting Test Case: {testCaseName} ***");
            log.Info("****************************************************************************************");
        }

        public static void EndTestCase(string testCaseName)
        {
            log.Info("****************************************************************************************");
            log.Info($"*** Ending Test Case: {testCaseName} ***");
            log.Info("****************************************************************************************");
        }

        public static void Info(string message)
        {
            log.Info(message);
        }
    }
}

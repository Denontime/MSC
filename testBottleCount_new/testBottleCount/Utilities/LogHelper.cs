using log4net;
using System.IO;

namespace BottlePickModuleForWindows.Utility
{
    public static class LogHelper
    {
        private static log4net.Repository.ILoggerRepository repository;
        private static ILog _logptl;
        private static ILog _logplc;
        private static ILog _logscanner;
        private static ILog _logdivertlanescanner;
        private static ILog _logerror;
        private static ILog _loginfo;
        private static ILog _logdebug;
        public static ILog LogEchat;
        public static ILog _LogIRStudy;
        public static ILog _logir;
        static LogHelper()
        {
            repository = log4net.LogManager.CreateRepository("NETCoreRepository");
            var fileInfo = new FileInfo(@"log4net.config");
            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
            log4net.Config.BasicConfigurator.Configure(repository);

            _logir = LogManager.GetLogger(repository.Name, "logir");
            _logscanner = LogManager.GetLogger(repository.Name, "logscanner");
            _logdivertlanescanner = LogManager.GetLogger(repository.Name, "logdivertlanescanner");
            _logerror = LogManager.GetLogger(repository.Name, "logerror");
            _loginfo = LogManager.GetLogger(repository.Name, "loginfo");
            _logdebug = LogManager.GetLogger(repository.Name, "logdebug");
            LogEchat = LogManager.GetLogger(repository.Name, "logechat");
            _logplc = LogManager.GetLogger(repository.Name, "logplc");
            _logptl = LogManager.GetLogger(repository.Name, "logptl");
            _LogIRStudy = LogManager.GetLogger(repository.Name, "LogIRStudy");
        }



        public static void LogIRStudy(string content)
        {
            if (_LogIRStudy.IsInfoEnabled)
            {
                _LogIRStudy.Info(content);
            }
        }

        //public static void Logoperator(string content)
        //{
        //    if (_logoperator.IsInfoEnabled)
        //    {
        //        _logoperator.Info(content);
        //    }
        //}

        // TaskID: 293708 WCS: create PTL log like scanner log
        public static void LogPTL(string content)
        {
            if (_logptl.IsInfoEnabled)
            {
                _logptl.Info(content);
            }
        }

        public static void LogPLC(string content)
        {
            if (_logplc.IsInfoEnabled)
            {
                _logplc.Info(content);
            }
        }

        public static void LogIR(string content)
        {
            if (_logir.IsInfoEnabled)
            {
                _logir.Info(content);
            }
        }


        public static void LogScanner(string content)
        {
            if (_logscanner.IsInfoEnabled)
            {
                _logscanner.Info(content);
            }
        }

        public static void LogDivertLaneScanner(string content)
        {
            if (_logdivertlanescanner.IsInfoEnabled)
            {
                _logdivertlanescanner.Info(content);
            }
        }

        public static void LogError(string content)
        {
            // Dim myUploadError As New UploadError()
            // Call myUploadError.UpLoadError2Server(content)
            // myUploadError = Nothing
            if (_logerror.IsErrorEnabled)
            {
                _logerror.Error(content);
            }
        }

        public static void LogInfo(string content)
        {
            if (_loginfo.IsInfoEnabled)
            {
                _loginfo.Info(content);
            }
        }

        public static void LogDebug(string content)
        {
            if (_logdebug.IsDebugEnabled)
            {
                _logdebug.Debug(content);
            }
        }
    }
}
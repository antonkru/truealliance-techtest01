using System;
using log4net;

namespace TechTest01.Services
{
    public class Logger : ILogManager
    {

        static readonly ILog _logger = LogManager.GetLogger("TechTest01");

        public bool IsDebugEnabled
        {
            get
            {
                return _logger.IsDebugEnabled;
            }
        }

        public bool IsErrorEnabled
        {
            get
            {
                return _logger.IsErrorEnabled;
            }
        }


        public void LogDebug(object message)
        {
            _logger.Debug(message);
        }

        public void LogDebugFormat(string format, params object[] args)
        {
            _logger.DebugFormat(format, args);
        }

        public void LogError(object message)
        {
            _logger.Error(message);
        }
        public void LogError(object message, Exception ex)
        {
            _logger.Error(message, ex);
        }


        public void LogErrorFormat(string format, params object[] args)
        {
            _logger.ErrorFormat(format, args);
        }

        public void LogInfo(object message)
        {
            _logger.Info(message);
        }

       

        public void LogInfoFormat(string format, params object[] args)
        {
            _logger.InfoFormat(format, args);
        }

        //public ILog Logger
        //{
        //    get
        //    {
        //        return _logger;
        //    }
        //}
    }
}
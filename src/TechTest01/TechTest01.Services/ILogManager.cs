

using System;

namespace TechTest01.Services
{
    public interface ILogManager
    {
      
        bool IsDebugEnabled { get; }


        bool IsErrorEnabled { get; }

        void LogDebug(object message);

        void LogDebugFormat(string format, params object[] args);


        void LogError(object message);

        void LogError(object message, Exception ex);


        void LogErrorFormat(string format, params object[] args);

       
        void LogInfo(object message);

   
        void LogInfoFormat(string format, params object[] args);
    }
}
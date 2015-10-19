using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
 
namespace MusicStore.Framework.Log
{
    //Nested Enum variable
    public enum Level
    {
        Debug = 0,
        Error = 1,
        Fatal = 2,
        Info = 3,
        Off = 4,
        Trace = 5,
        Warn = 6
    }
 
    public static class WrapperLogger
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
 
        public static void Log(string msg, Level enumLevel, Exception ex)
        {
 
            logger.Log(verifyNlogLevel(enumLevel), msg, ex);
        }
 
        private static LogLevel verifyNlogLevel( Level enumLevel = Level.Debug )
        {
 
            switch (enumLevel)
            {
 
                case Level.Debug:
                    return LogLevel.Debug;
                    break;
 
                case Level.Error:
                    return LogLevel.Error;
                    break;
                
                case Level.Fatal:
                    return LogLevel.Fatal;
                    break;
 
                case Level.Info:
                    return LogLevel.Info;
                    break;
 
                case Level.Off:
                    return LogLevel.Off;
                    break;
 
                case Level.Trace:
                    return LogLevel.Trace;
                    break;
 
                case Level.Warn:
                    return LogLevel.Warn;
                    break;
            
                default:
                    return LogLevel.Debug;
                    break;
            }
        
        }
 
    }
}

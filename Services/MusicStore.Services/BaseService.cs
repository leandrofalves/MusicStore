using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using MusicStore.Framework.Log;
using MusicStore.Entities;
using MusicStore.Entities.Services;

namespace MusicStore.Services
{
    public abstract class BaseService
    {
        protected ExceptionReturn FormatException(Exception ex) 
        {
            
            return new ExceptionReturn(string.Empty,string.Empty, ex.Message);
        
        }
 
        protected void LogServiceException(string msg, Exception ex) 
        {
 
            WrapperLogger.Log(msg, Level.Error, ex);  
        }
 
        protected void LogServiceExecuted(string msg) 
        {
 
            WrapperLogger.Log(msg, Level.Info, null);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace MusicStore.Entities.Services
{
    [DataContract(Name="ServiceReturn")]
    public class ServiceReturn
    {
        [DataMember(Name="status", Order=1)]
        public string status { get; set; }

        [DataMember(Name = "responseData", Order=2)]
        public Object responseData { get; set; }

        [DataMember(Name="exception", Order=3)]
        public ExceptionReturn exception { get; set; }

        public ServiceReturn()
        { 
        }

        public ServiceReturn(string Status):this(Status,null,null) 
        { 
        }

        public ServiceReturn(string Status, Object ResponseData):this(Status,ResponseData,null) 
        {        
        }

        public ServiceReturn(string Status, Object ResponseData, ExceptionReturn Exception) 
        {
            this.status = Status;
            this.responseData = ResponseData;
            this.exception = Exception;
        }

    }
}

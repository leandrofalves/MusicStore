using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace MusicStore.Entities.Services
{
    [DataContract(Name = "ExceptionReturn")]
    public class ExceptionReturn
    {
        [DataMember(Name = "exceptionCode",Order=1)]
        public string exceptionCode { get; set; }

        [DataMember(Name = "exceptionDescription", Order = 2)]
        public string exceptionDescription { get; set; }

        [DataMember(Name = "exceptionTrace", Order = 3)]
        public string exceptionTrace { get; set; }

        private ExceptionReturn() 
        { 
        
        }

        public ExceptionReturn(string Code, string Description, string ExceptionTrace) 
        {
            this.exceptionCode = Code;
            this.exceptionDescription = Description;
            this.exceptionTrace = ExceptionTrace;
        }
    }
}
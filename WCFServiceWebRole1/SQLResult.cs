﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WCFServiceWebRole1
{
    [DataContract]
    public class wsSQLResult
    {
        [DataMember]
        public int WasSuccessful { get; set; }

        [DataMember]
        public string Exception { get; set; }
    }
}
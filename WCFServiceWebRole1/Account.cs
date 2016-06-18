using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServiceWebRole1
{
    [DataContract]
    public class wsAccount
    {
        [DataMember]
        public int AccountID { get; set; }

        [DataMember]
        public decimal balance { get; set; }

        [DataMember]
        public decimal   runningTotals { get; set; }

        [DataMember]
        public string firstName { get; set; }

        [DataMember]
        public string lastName { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string postCode { get; set; }

        [DataMember]
        public string telePhone { get; set; }

        [DataMember]
        public string pin { get; set; }
    }
}
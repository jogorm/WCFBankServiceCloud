using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WCFServiceWebRole1
{
    [DataContract]
    public class wsTransaction
    {
        [DataMember]
        public int Trans_ID { get; set; }

        [DataMember]
        public decimal amount { get; set; }

        [DataMember]
        public DateTime dateTime { get; set; }

        [DataMember]
        public int acc_id { get; set; }
    }
}
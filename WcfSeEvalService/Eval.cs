using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfSeEvalService
{
    [DataContract]
    public class Eval
    {
        [DataMember]
        public int Id;
        [DataMember]
        public string Submiter;
        [DataMember]
        public string Comment;
        [DataMember]
        public DateTime Timesumetted;

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ProjectwerkCursistenportaal.BLL
{
    [DataContract]
    public class Plaatsing
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Cursist Cursist { get; set; }
        [DataMember]
        public DateTime StartDatum { get; set; }
        [DataMember]
        public DateTime EindDatum { get; set; }
    }
}
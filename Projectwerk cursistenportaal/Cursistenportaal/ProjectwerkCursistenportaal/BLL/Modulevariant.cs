using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ProjectwerkCursistenportaal
{
    [DataContract]
    public class Modulevariant
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Code { get; set; }
        [DataMember]
        public DateTime Aanvangsdatum { get; set; }
        [DataMember]
        public DateTime EindDatum { get; set; }

    }
}
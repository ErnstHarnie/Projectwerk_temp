using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ProjectwerkCursistenportaal.BLL
{
    [DataContract]
    public class Module
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Naam { get; set; }

    }
}

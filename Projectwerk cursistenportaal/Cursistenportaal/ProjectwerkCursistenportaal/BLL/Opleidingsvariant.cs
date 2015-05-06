using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ProjectwerkCursistenportaal.BLL
{
    public class Opleidingsvariant
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Naam { get; set; }
        [DataMember]
        public int Code { get; set; }
        [DataMember]
        public int Opleiding { get; set; }
    }
}

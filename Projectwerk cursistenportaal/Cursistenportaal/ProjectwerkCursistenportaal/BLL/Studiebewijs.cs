using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ProjectwerkCursistenportaal.BLL
{
    public class Studiebewijs
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Cursist { get; set; }
        [DataMember]
        public int Studiebewijstype { get; set; }
       
    }
}
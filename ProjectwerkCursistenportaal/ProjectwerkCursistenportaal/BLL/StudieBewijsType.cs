using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ProjectwerkCursistenportaal.BLL
{
    [DataContract]
    public class StudieBewijsType
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Code { get; set; }
        [DataMember]
        public string Omschrijving { get; set; }
        [DataMember]
        public DateTime EindDatum { get; set; }
        [DataMember]
        public DateTime Aanvangsdatum { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ProjectwerkCursistenportaal.BLL
{
    [DataContract]
    public class PlaatsingHistoriek
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int IdCursist { get; set; }
        [DataMember]
        public int IdPlaatsingResultaat { get; set; }
        [DataMember]
        public int IdPlaatsingsStatus { get; set; }
    }
}
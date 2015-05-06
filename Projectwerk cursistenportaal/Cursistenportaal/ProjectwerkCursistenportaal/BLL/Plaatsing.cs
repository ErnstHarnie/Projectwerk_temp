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
        public bool IsBetaaldEducatiefVerlof { get; set; }
        [DataMember]
        public int IdCursist { get; set; }
        [DataMember]
        public string IdIngerichteOpleidingsVariant { get; set; }
        [DataMember]
        public string IdIngerichteModuleVariant { get; set; }

        [DataMember]
        public DateTime ReservatieDatum { get; set; }
        [DataMember]
        public string IdPlaatsingsStatus { get; set; }
        [DataMember]
        public bool GevalideerdDoorCentrum { get; set; }
        [DataMember]
        public bool GecontroleerdDoorCentrum { get; set; }


    }
}
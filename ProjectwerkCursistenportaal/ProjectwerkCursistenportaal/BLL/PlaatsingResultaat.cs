using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ProjectwerkCursistenportaal.BLL
{
    [DataContract]
    public class PlaatsingResultaat
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int PuntenTotaal { get; set; }
        [DataMember]
        public int PuntenPermanenteEvaluatie { get; set; }
        [DataMember]
        public int PuntenPermanenteEvaluatieNaDeliberatie { get; set; }
        [DataMember]
        public int PuntenEersteZit { get; set; }
        [DataMember]
        public int PuntenEersteZitNaDeliberatie { get; set; }
        [DataMember]
        public int PuntenTweedeZit { get; set; }
        [DataMember]
        public int PuntenTweedeZitNaDeliberatie { get; set; }
    }
}
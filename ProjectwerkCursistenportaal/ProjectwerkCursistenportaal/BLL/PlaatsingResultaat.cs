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
        public double PuntenTotaal { get; set; }
        [DataMember]
        public double PuntenPermanenteEvaluatie { get; set; }
        [DataMember]
        public double PuntenPermanenteEvaluatieNaDeliberatie { get; set; }
        [DataMember]
        public double PuntenEersteZit { get; set; }
        [DataMember]
        public double PuntenEersteZitNaDeliberatie { get; set; }
        [DataMember]
        public double PuntenTweedeZit { get; set; }
        [DataMember]
        public double PuntenTweedeZitNaDeliberatie { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ProjectwerkCursistenportaal.BLL
{
    [DataContract]
    public class IngerichteModuleVariant
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int IdModuleVariant { get; set; }
        [DataMember]
        public int CursusNummer { get; set; }
        [DataMember]
        public string Naam { get; set; }
        [DataMember]
        public DateTime AanvangsDatum { get; set; }
        [DataMember]
        public DateTime EindDatum { get; set; }
        [DataMember]
        public int MaximumCapaciteit { get; set; }
        [DataMember]
        public int LesTijdenOrganisatie { get; set; }
        [DataMember]
        public int LesTijdenAfstandsOnderwijs { get; set; }
        [DataMember]
        public DateTime DateumTweedeZit { get; set; }
        [DataMember]
        public double KostPrijsCursusMateriaal { get; set; }
    }
}
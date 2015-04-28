using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;


namespace ProjectwerkCursistenportaal.BLL
{
    [DataContract]
    public class Cursist
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Cursistnummer { get; set; }
        [DataMember]
        public string Voornaam { get; set; }
        [DataMember]
        public string Familienaam { get; set; }

    }


}

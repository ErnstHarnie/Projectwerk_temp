using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectwerkCursistenportaal.BLL
{
    public class Opleiding
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }
        public DateTime AanvangsDatum { get; set; }
        public DateTime EindDatum { get; set; }
        public Opleidingsgebied Opleidingsgebied { get; set; }
    }
}

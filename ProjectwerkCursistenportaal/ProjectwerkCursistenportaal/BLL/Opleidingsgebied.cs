using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectwerkCursistenportaal.BLL
{
    public class Opleidingsgebied
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public int Code { get; set; }
        public DateTime Aanvangsdatum { get; set; }
        public DateTime EindDatum { get; set; }

    }
}

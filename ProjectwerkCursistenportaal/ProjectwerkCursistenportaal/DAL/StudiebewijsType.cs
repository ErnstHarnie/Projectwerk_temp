using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectwerkCursistenportaal.DAL
{
    class StudiebewijsType
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Omschrijving { get; set; }
        public DateTime AanvangsDatum { get; set; }
        public DateTime EindDatum { get; set; }
    }
}

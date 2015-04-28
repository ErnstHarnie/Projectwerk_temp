﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ProjectwerkCursistenportaal.BLL
{
    public class Studiebewijsopleiding
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Omschrijving { get; set; }
        [DataMember]
        public int Opleidingsvariant { get; set; }
        [DataMember]
        public int Studiebewijstype { get; set; }
    }
}
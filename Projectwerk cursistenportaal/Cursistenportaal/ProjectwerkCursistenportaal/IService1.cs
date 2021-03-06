﻿using ProjectwerkCursistenportaal.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProjectwerkCursistenportaal
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        List<Cursist> GetCursisten();
        [OperationContract]
        List<Cursist> GetCursistId(int Id);
        [OperationContract]
        List<Opleiding> GetOpleidingen();
        [OperationContract]
        List<PlaatsingResultaat> GetPlaatsingResultaat(int Id);
        [OperationContract]
        List<Opleidingsvariant> GetOpleidingsVarianten();
        [OperationContract]
        List<Opleidingsvariant> GetOpleidingsVariantId(int Id);
        [OperationContract]
        List<Studiebewijs> GetStudieBewijzen(int Id);
        //[OperationContract]
        //List<Plaatsing> GetPlaatsing(int Id);

        //[OperationContract]
        //List<PlaatsingHistoriek> GetLesMomenten(int Id);
        [OperationContract]
        List<Studiebewijsopleiding> GetStudiebewijsOpleiding();
        [OperationContract]
        List<StudieBewijsType> GetStudiebewijsType();
        [OperationContract]
        List<StudiebewijsGraadType> GetStudiebewijsGraadType();

        //[OperationContract]
        //bool InsertLesMomenten(PlaatsingHistoriek ph, int CursistId);
        //[OperationContract]
        //bool UpdateLesMomenten(PlaatsingHistoriek ph, int CursistId);
        //[OperationContract]
        //bool DeleteLesMomenten(int CursistId);


    }

        [DataContract]
    public class StudieBewijsType
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Omschrijving { get; set; }
        [DataMember]
        public DateTime EindDatum { get; set; }
        [DataMember]
        public DateTime Aanvangsdatum { get; set; }
        
    }

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

    public class Studiebewijsopleiding
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Omschrijving { get; set; }
        [DataMember]
        public string Opleidingsvariant { get; set; }
        [DataMember]
        public string Studiebewijstype { get; set; }
    }

    public class StudiebewijsGraadType
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Omschrijving { get; set; }
        [DataMember]
        public double Min { get; set; }
        [DataMember]
        public double Max { get; set; }
    }

    [DataContract] 
    public class Opleiding
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Naam { get; set; }
        [DataMember]
        public string Omschrijving { get; set; }
        [DataMember]
        public DateTime AanvangsDatum { get; set; }
        [DataMember]
        public DateTime EindDatum { get; set; }
        [DataMember]
        public Opleidingsgebied Opleidingsgebied { get; set; }
    }

    public class Opleidingsvariant
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Naam { get; set; }
        [DataMember]
        public int Code { get; set; }
        [DataMember]
        public int Opleiding { get; set; }
    }

    public class Studiebewijs
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Cursist { get; set; }
        [DataMember]
        public string Studiebewijstype { get; set; }

    }


    [DataContract]
    public class PlaatsingHistoriek
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int IdCursist { get; set; }
        [DataMember]
        public int IdPlaatsingResultaat { get; set; }
       // [DataMember]
       // public int IdPlaatsingsStatus { get; set; }
        [DataMember]
        public DateTime Startdatum { get; set; }
        [DataMember]
        public DateTime Einddatum { get; set; }
        [DataMember]
        public int Percentage { get; set; }
        [DataMember]
        public int isGeannuleerd { get; set; }
    }


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

using ProjectwerkCursistenportaal.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProjectwerkCursistenportaal
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService
    {
        DalDb data;
        public Service1()
        {

            data = new DalDb();
        }

       public List<Cursist> GetCursisten()
        {
            return data.GetCursisten();
        }

        public List<Cursist> GetCursistId(int Id)
       {
           return data.GetCursistId(Id);
       }

        public List<Opleiding> GetOpleidingen()
        {
            return data.GetOpleidingen();
        }

        public List<PlaatsingResultaat> GetPlaatsingResultaat(int Id)
        {
            return data.GetPlaatsingResultaat(Id);
        }

        public List<Opleidingsvariant> GetOpleidingsVarianten()
        {
            return data.GetOpleidingsVariant();
        }

        //public List<Plaatsing> GetPlaatsing(int Id)
        //{
        //    return data.GetPlaatsing(Id);
        //}


        public List<Opleidingsvariant> GetOpleidingsVariantId(int Id)
    {
        return data.GetOpleidingsVariantId(Id);
    }

        public List<Studiebewijs> GetStudieBewijzen(int Id)
        {
            return data.GetStudiebewijs(Id);
        }

        public List<StudiebewijsGraadType> GetStudiebewijsGraadType()
        {
            return data.GetStudiebewijsGraadTypes();
        }

    //    public List<PlaatsingHistoriek> GetLesMomenten(int Id)
    //{
    //    return data.GetLesMomenten(Id);
    //}

        public List<Studiebewijsopleiding> GetStudiebewijsOpleiding()
        {
            return data.GetStudiebewijsOpleiding();
        }

        public List<StudieBewijsType>  GetStudiebewijsType()
        {
            return data.GetStudieBewijsType();
        }

        //public bool InsertLesMomenten(PlaatsingHistoriek ph, int CursistId)
        //{
        //    return true;
        //}

        //public bool UpdateLesMomenten(PlaatsingHistoriek ph, int CursistId)
        //{
        //    return true;
        //}

        //public bool DeleteLesMomenten(int CursistId)
        //{
        //    return true;
        //}


    }
}

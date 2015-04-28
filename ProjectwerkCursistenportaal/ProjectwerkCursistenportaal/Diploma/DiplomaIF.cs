using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ProjectwerkCursistenportaal.Diploma
{
    interface DiplomaIF
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
            //List<PlaatsingHistoriek> GetLesMomenten(int Id);
            [OperationContract]
            List<Studiebewijsopleiding> GetStudiebewijsOpleiding();
            [OperationContract]
            List<StudieBewijsType> GetStudiebewijsType();

            [OperationContract]
            bool InsertLesMomenten(PlaatsingHistoriek ph, int CursistId);
            [OperationContract]
            bool UpdateLesMomenten(PlaatsingHistoriek ph, int CursistId);
            [OperationContract]
            bool DeleteLesMomenten(int CursistId);


        
    }
}

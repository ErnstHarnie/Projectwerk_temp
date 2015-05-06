using ProjectwerkCursistenportaal.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectwerkCursistenportaal.DAL
{
    public class DalDb
    {
        public DalDb()
        {

        }

        /// <summary>
        /// Haalt lijst van alle cursisten op
        /// </summary>
        /// <returns></returns>
        public List<Cursist> GetCursisten()
        {
            List<Cursist> list = new List<Cursist>();
            string sql = "SELECT id, CursistNummer, Voornaam, Familienaam FROM cursist";

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dr.Read())
                    {
                        Cursist c = new Cursist();
                        c.Id = Convert.ToInt32(dr["Id"]);
                        c.Cursistnummer = Convert.ToInt32(dr["CursistNummer"]);
                        c.Voornaam = dr["Voornaam"].ToString();
                        c.Familienaam = dr["Familienaam"].ToString();
                        list.Add(c);
                    }
                    dr.Close();
                }

            }
            return list;

        }


        /// <summary>
        /// Haalt 1 cursist op
        /// </summary>
        /// <param name="cursistId"></param>
        /// <returns></returns>
        public List<Cursist> GetCursistId(int cursistId)
        {
            List<Cursist> list = new List<Cursist>();
            string sql = "SELECT id, CursistNummer, Voornaam, Familienaam FROM cursist WHERE CursistNummer=" + cursistId;

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dr.Read())
                    {
                        Cursist c = new Cursist();
                        c.Id = Convert.ToInt32(dr["Id"]);
                        c.Cursistnummer = Convert.ToInt32(dr["CursistNummer"]);
                        c.Voornaam = dr["Voornaam"].ToString();
                        c.Familienaam = dr["Familienaam"].ToString();
                        list.Add(c);
                    }
                    dr.Close();
                }

            }
            return list;
        }

        /// <summary>
        /// Haalt alle opleidingen op
        /// </summary>
        /// <returns></returns>
        public List<Opleiding> GetOpleidingen()
        {
            List<Opleiding> list = new List<Opleiding>();
            string sql = "SELECT Id, Naam, Omschrijving FROM Opleiding";

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dr.Read())
                    {
                        Opleiding o = new Opleiding();
                        o.Id = Convert.ToInt32(dr["Id"]);
                        o.Naam = dr["Naam"].ToString();
                        o.Omschrijving = dr["Omschrijving"].ToString();
                        list.Add(o);
                    }
                    dr.Close();
                }

            }
            return list;
        }


        /// <summary>
        /// Haalt Resultaat op
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<PlaatsingResultaat> GetPlaatsingResultaat(int Id)
        {
            List<PlaatsingResultaat> list = new List<PlaatsingResultaat>();
            string sql = "SELECT Id, PuntenTotaal, PuntenPermanenteEvaluatie, PuntenEersteZit, PuntenTweedeZit, PuntenEersteZitNaDeliberatie, PuntenTweedeZitNaDeliberatie FROM PlaatsingResultaat WHERE Id = " + Id;

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dr.Read())
                    {
                        PlaatsingResultaat pr = new PlaatsingResultaat();
                        pr.Id = Convert.ToInt32(dr["Id"]);
                        pr.PuntenEersteZit = Convert.ToDouble(dr["PuntenEersteZit"]);
                        pr.PuntenEersteZitNaDeliberatie = Convert.ToDouble(dr["PuntenEersteZitNaDeliberatie"]);
                        pr.PuntenPermanenteEvaluatie = Convert.ToDouble(dr["PuntenPermanenteEvaluatie"]);
                        pr.PuntenTotaal = Convert.ToDouble(dr["PuntenTotaal"]);
                        pr.PuntenTweedeZit = Convert.ToDouble(dr["PuntenTweedeZit"]);
                        pr.PuntenTweedeZitNaDeliberatie = Convert.ToDouble(dr["PuntenTweedeZitNadeliberatie"]);
                        list.Add(pr);
                    }
                    dr.Close();
                }

            }
            return list;
        }


        /// <summary>
        /// Haalt lijst van alle opleidingsvarianten op
        /// </summary>
        /// <returns></returns>
        public List<Opleidingsvariant> GetOpleidingsVariant()
        {
            List<Opleidingsvariant> list = new List<Opleidingsvariant>();
            string sql = "SELECT Id, Naam, Code FROM Opleidingsvariant";
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (dr.Read())
                    {
                        Opleidingsvariant ov = new Opleidingsvariant();
                        ov.Id = Convert.ToInt32(dr["Id"]);
                        ov.Naam = dr["Naam"].ToString();
                        ov.Code = Convert.ToInt32(dr["Code"]);
                        list.Add(ov);
                    }
                    dr.Close();
                }
            }
            return list;
        }

        /// <summary>
        /// Haalt alle verschillende diploma's en certificaten op voor alle opleidingen
        /// </summary>
        /// <returns>Studiebewijsopleiding</returns>
        public List<Studiebewijsopleiding> GetStudiebewijsOpleiding()
        {
            List<Studiebewijsopleiding> list = new List<Studiebewijsopleiding>();
            string sql = 
                "SELECT StudiebewijsOpleiding.Id, StudiebewijsOpleiding.Omschrijving, Opleidingsvariant.Naam, StudiebewijsType.Code FROM StudiebewijsOpleiding INNER JOIN Opleidingsvariant ON StudiebewijsOpleiding.IdOpleidingsvariant=Opleidingsvariant.Id INNER JOIN StudiebewijsType ON StudiebewijsOpleiding.IdStudiebewijsType=StudiebewijsType.Id";
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dr.Read())
                    {
                        Studiebewijsopleiding sbo = new Studiebewijsopleiding();
                        sbo.Id = Convert.ToInt32(dr["Id"]);
                        sbo.Omschrijving = dr["Omschrijving"].ToString();
                        sbo.Opleidingsvariant =dr["Naam"].ToString();
                        sbo.Studiebewijstype = dr["Code"].ToString();
                        list.Add(sbo);
                    }
                    dr.Close();
                }
            }
            return list;
        }

        /// <summary>
        /// Haalt de verschillende vormen van certificaten, attesten en diploma's op
        /// </summary>
        /// <returns>StudieBewijsType</returns>
        public List<StudieBewijsType> GetStudieBewijsType()
        {
            List<StudieBewijsType> list = new List<StudieBewijsType>();
            string sql = "SELECT Id, Code, Omschrijving FROM StudiebewijsType";
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (dr.Read())
                    {
                        StudieBewijsType sbt = new StudieBewijsType();
                        sbt.Id = Convert.ToInt32(dr["Id"]);
                        sbt.Omschrijving = dr["Omschrijving"].ToString();
                        sbt.Code = dr["Code"].ToString();
                        list.Add(sbt);
                    }
                    dr.Close();
                }
            }
            return list;
        }


        /// <summary>
        /// Haalt studiebewijzen op die cursist heeft behaald
        /// </summary>
        /// <param name="cursistId"></param>
        /// <returns></returns>
        public List<Studiebewijs> GetStudiebewijs(int cursistId)
        {
            List<Studiebewijs> list = new List<Studiebewijs>();
            string sql = "SELECT Studiebewijs.Id, Studiebewijs.idCursist, Studiebewijs.idStudieBewijsType, StudiebewijsType.Code FROM Studiebewijs INNER JOIN StudiebewijsType ON Studiebewijs.idStudieBewijsType=StudiebewijsType.Id WHERE Studiebewijs.IdCursist=" + cursistId;
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (dr.Read())
                    {
                        Cursist c = new Cursist();
                        Studiebewijs s = new Studiebewijs();
                        s.Cursist = Convert.ToInt32(dr["idCursist"]);
                        s.Id = Convert.ToInt32(dr["Id"]);
                        s.Studiebewijstype = dr["Code"].ToString();
                        list.Add(s);
                    }
                    dr.Close();
                }
            }
            return list;
        }

        /// <summary>
        /// Haalt 1 opleiding op
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<Opleidingsvariant> GetOpleidingsVariantId(int Id)
        {
            List<Opleidingsvariant> list = new List<Opleidingsvariant>();
            string sql = "SELECT Id, Naam, Code, IdOpleiding FROM Opleidingsvariant WHERE id=" + Id;
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (dr.Read())
                    {
                        Opleidingsvariant ov = new Opleidingsvariant();
                        ov.Id = Convert.ToInt32(dr["Id"]);
                        ov.Naam = dr["Naam"].ToString();
                        ov.Code = Convert.ToInt32(dr["Code"]);
                        ov.Opleiding = Convert.ToInt32(dr["IdOpleiding"]);
                        list.Add(ov);
                    }
                    dr.Close();
                }
            }
            return list;
        }

        /// <summary>
        /// Haalt de verschillende graadtypes op (voldoening, onderscheiding, gr. onderscheiding, grootste onderscheiding)
        /// </summary>
        /// <returns>StudiebewijsGraadType</returns>
        public List<StudiebewijsGraadType> GetStudiebewijsGraadTypes()
        {
            List<StudiebewijsGraadType> list = new List<StudiebewijsGraadType>();
            string sql = "SELECT  Id, Omschrijving, Min, Max FROM StudiebewijsGraadType";
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (dr.Read())
                    {
                        StudiebewijsGraadType sgt = new StudiebewijsGraadType();
                        sgt.Id = Convert.ToInt32(dr["Id"]);
                        sgt.Omschrijving = dr["Omschrijving"].ToString();
                        sgt.Min = Convert.ToDouble(dr["Min"]);
                        if (dr["Max"] != System.DBNull.Value)
                        {
                           sgt.Max = Convert.ToDouble(dr["Max"]);
                        }

                        list.Add(sgt);
                    }
                    dr.Close();
                }
            }
            return list;
        }


        /* --------------------------------------------- NIET GEBRUIKT  ---------------------------------------------  */


        ///// <summary>
        ///// Haalt de gereserveerde/ingeschreven cursist op 
        ///// </summary>
        ///// <param name="IdCursist"></param>
        ///// <returns>Plaatsing</returns>
        //public List<Plaatsing> GetPlaatsing(int IdCursist)
        //{
        //    List<Plaatsing> list = new List<Plaatsing>();
        //    string sql = "SELECT Plaatsing.Id, Plaatsing.IdIngerichteModulevariant, Plaatsing.IdIngerichteOpleidingsvariant, Plaatsing.Reservatiedatum, Plaatsing.IsBetaaldEducatiefVerlof, Plaatsing.GevalideerdDoorCentrum, Plaatsing.GecontroleerdDoorCentrum FROM Plaatsing INNER JOIN Opleidingsvariant ON Plaatsing.IdIngerichteOpleidingsVariant=Opleidingsvariant.Naam INNER JOIN Modulevariant ON Plaatsing.IdIngerichteModuleVariant=Modulevariant.Naam INNER JOIN PlaatsingsStatusType ON Plaatsing.IdPlaatsingsstatus=PlaatsingsStatusType.Omschrijving WHERE Plaatsing.IdCursist=" + IdCursist;
        //    using (SqlConnection con = new SqlConnection(GetConnectionString()))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(sql, con))
        //        {
        //            con.Open();
        //            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        //            while (dr.Read())
        //            {
        //                Plaatsing p = new Plaatsing();
        //                p.Id = Convert.ToInt32(dr["Id"]);
        //                p.IdIngerichteModuleVariant = dr["IdIngerichteModulevariant"].ToString();
        //                p.IdIngerichteOpleidingsVariant = dr["IdIngerichteOpleidingsvariant"].ToString();
        //                p.IdPlaatsingsStatus = dr["IdPlaatsingsstatus"].ToString();
        //                p.IsBetaaldEducatiefVerlof = Convert.ToBoolean(dr["IsBetaaldEducatiefVerlof"]);
        //                p.ReservatieDatum = Convert.ToDateTime(dr["ReservatieDatum"]);
        //                p.GevalideerdDoorCentrum = Convert.ToBoolean(dr["GevalideerdDoorCentrum"]);
        //                p.GecontroleerdDoorCentrum = Convert.ToBoolean(dr["GecontroleerdDoorCentrum"]);
        //            }
        //            dr.Close();
        //        }
        //    }
        //    return list;
        //}



        //public List<PlaatsingHistoriek> GetLesMomenten(int cursistId)
        //{
        //    List<PlaatsingHistoriek> list = new List<PlaatsingHistoriek>();
        //    string sql = "SELECT Id, idCursist, Startdatum, Einddatum, idEvaluatieresultaat, Resultaatdatum, Percentage, isGeannuleerd FROM Plaatsinghistoriek WHERE IdCursist = " + cursistId;
        //    using (SqlConnection con = new SqlConnection(GetConnectionString()))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(sql, con))
        //        {
        //            con.Open();
        //            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

        //            while (dr.Read())
        //            {
        //                PlaatsingHistoriek ph = new PlaatsingHistoriek();
        //                ph.Id = Convert.ToInt32(dr["Id"]);
        //                ph.IdCursist = Convert.ToInt32(dr["idCursist"]);
        //                ph.Startdatum = Convert.ToDateTime(dr["Startdatum"]);
        //                ph.Einddatum = Convert.ToDateTime(dr["Einddatum"]);
        //                ph.Percentage = Convert.ToInt32(dr["Percentage"]);
        //                ph.isGeannuleerd = Convert.ToInt32(dr["isGeannuleerd"]);
        //                list.Add(ph);
        //            }
        //            dr.Close();
        //        }
        //    }
        //    return list;
        //}

        //public bool InsertLesMomenten(PlaatsingHistoriek ph, int cursistId)
        //{

        //    try
        //    {
        //        string sql = "INSERT INTO Plaatsinghistoriek (Id, idCursist, Startdatum, Einddatum, Percentage, isGeannuleerd) VALUES " + ph.Id + ", " + ph.IdCursist + ", " + ph.Startdatum + "," + ph.Einddatum + ", " + ph.Percentage + "," + ph.isGeannuleerd + " WHERE IdCursist = " + cursistId;
        //        using (SqlConnection con = new SqlConnection(GetConnectionString()))
        //        {
        //            using (SqlCommand cmd = new SqlCommand(sql, con))
        //            {
        //                con.Open();
        //                cmd.CommandText = sql;
        //                int count = (int)cmd.ExecuteScalar();



        //            }
        //        }
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        //public bool UpdateLesMomenten(PlaatsingHistoriek ph, int Id)
        //{

        //    try
        //    {
        //        string sql = "UPDATE Plaatsinghistoriek Set Id='" + ph.Id + "', idCursist='" + ph.IdCursist + "', Startdatum='" + ph.Startdatum + "',Einddatum='" + ph.Einddatum + "', Percentage='" + ph.Percentage + "',isGeannuleerd='" + ph.isGeannuleerd + "' WHERE Id = " + Id;
        //        using (SqlConnection con = new SqlConnection(GetConnectionString()))
        //        {
        //            using (SqlCommand cmd = new SqlCommand(sql, con))
        //            {
        //                con.Open();
        //                cmd.CommandText = sql;
        //                int count = (int)cmd.ExecuteScalar();



        //            }
        //        }
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        //public bool DeleteLesMomenten(int Id)
        //{
        //    try
        //    {
        //        string sql = "DELETE FROM Plaatsinghistoriek WHERE Id=" + Id;
        //        using (SqlConnection con = new SqlConnection(GetConnectionString()))
        //        {
        //            using (SqlCommand cmd = new SqlCommand(sql, con))
        //            {
        //                con.Open();
        //                cmd.CommandText = sql;
        //                int count = (int)cmd.ExecuteScalar();
        //            }
        //        }
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}




        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Cursistenportaal"].ConnectionString; // offline database
            // return ConfigurationManager.ConnectionStrings["Onlineportaal"].ConnectionString; // online database
        }
    }
}
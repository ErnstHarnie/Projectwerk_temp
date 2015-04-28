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

        public List<Studiebewijsopleiding> GetStudiebewijsOpleiding()
        {
            List<Studiebewijsopleiding> list = new List<Studiebewijsopleiding>();
            string sql = "SELECT Id, Omschrijving, IdOpleidingsvariant, IdStudiebewijstype FROM Opleiding";
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
                        sbo.Opleidingsvariant = Convert.ToInt32(dr["IdOpleidingsvariant"]);
                        sbo.Studiebewijstype = Convert.ToInt32(dr["IdStudiebewijstype"]);
                        list.Add(sbo);
                    }
                    dr.Close();
                }
            }
            return list;
        }

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

        public List<Studiebewijs> GetStudiebewijs(int cursistId)
        {
            List<Studiebewijs> list = new List<Studiebewijs>();
            string sql = "SELECT Id, idCursist, idStudieBewijsType FROM Studiebewijs WHERE idCursist = " + cursistId;
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
                        s.Studiebewijstype = Convert.ToInt32(dr["idStudieBewijsType"]);
                        list.Add(s);
                    }
                    dr.Close();
                }
            }
            return list;
        }

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

        public bool InsertLesMomenten(PlaatsingHistoriek ph, int cursistId)
        {

            try
            {
                string sql = "INSERT INTO Plaatsinghistoriek (Id, idCursist, Startdatum, Einddatum, Percentage, isGeannuleerd) VALUES " + ph.Id + ", " + ph.IdCursist + ", " + ph.Startdatum + "," + ph.Einddatum + ", " + ph.Percentage + "," + ph.isGeannuleerd + " WHERE IdCursist = " + cursistId;
                using (SqlConnection con = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        con.Open();
                        cmd.CommandText = sql;
                        int count = (int)cmd.ExecuteScalar();



                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateLesMomenten(PlaatsingHistoriek ph, int Id)
        {

            try
            {
                string sql = "UPDATE Plaatsinghistoriek Set Id='" + ph.Id + "', idCursist='" + ph.IdCursist + "', Startdatum='" + ph.Startdatum + "',Einddatum='" + ph.Einddatum + "', Percentage='" + ph.Percentage + "',isGeannuleerd='" + ph.isGeannuleerd + "' WHERE Id = " + Id;
                using (SqlConnection con = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        con.Open();
                        cmd.CommandText = sql;
                        int count = (int)cmd.ExecuteScalar();



                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteLesMomenten(int Id)
        {
            try
            {
                string sql = "DELETE FROM Plaatsinghistoriek WHERE Id=" + Id;
                using (SqlConnection con = new SqlConnection(GetConnectionString()))
                
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        con.Open();
                        cmd.CommandText = sql;
                        int count = (int)cmd.ExecuteScalar();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }




        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Cursistenportaal"].ConnectionString;
        }
    }
}
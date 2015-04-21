using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectwerkCursistenportaal.DAL
{
    public class Studiebewijs
    {

        public BLL.Studiebewijs AttestOphalen(BLL.StudieBewijsType sbt)
        {
            BLL.Studiebewijs studieBewijs = new BLL.Studiebewijs();
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Cursistenportaal"].ToString();
            SqlCommand command = new SqlCommand();

            string sqlString = "SELECT * FROM `studiebewijs` WHERE `idStudieBewijsType`=?";

            command.Parameters.Add(new SqlParameter("@idStudieBewijsType", SqlDbType.Int)).Value = sbt;
            command.CommandType = CommandType.StoredProcedure;

            command.CommandText = sqlString;

            command.Connection = connection;

            SqlDataReader result;

            try
            {
                connection.Open();

                using (result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        result.Read();
                        studieBewijs.Id = (int)result["Id"];
                        
                    }
                }

            }
            catch (Exception ex) 
            {
                return null;
            }
            finally
            {
                connection.Close();
            }

            return studieBewijs;
        }

        public List<BLL.Studiebewijs> AttestenOphalen()
        {
            List<BLL.Studiebewijs> studieBewijsList = new List<BLL.Studiebewijs>();
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Cursistenportaal"].ToString();
            SqlCommand command = new SqlCommand();

            string sqlString = "SELECT * FROM `Studiebewijs`";

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sqlString;
            command.Connection = connection;

            SqlDataReader result;

            try
            {
                connection.Open();

                using (result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        while (result.Read())
                        {
                            BLL.Studiebewijs sb = new BLL.Studiebewijs();
                            sb.Cursist = (int)result["idCursist"];
                            sb.Id = (int)result["Id"];
                            sb.Studiebewijstype = (int)result["idStudiebewijstype"];
                            studieBewijsList.Add(sb);
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }

            return studieBewijsList;
        }



    }

    
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data.SqlClient;

namespace Data
{
    public class DMoneda
    {
        public static Moneda GetById(int idMoneda)
        {
            Moneda result = new Moneda();
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetByIDMoneda", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idMoneda", idMoneda);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = new Moneda(Convert.ToInt32(reader["idMoneda"]), 
                        reader["descripcion"].ToString(),
                        reader["codAFIP"].ToString());
                }

               
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public static List<Moneda> GetAll()
        {
            List<Moneda> result = new List<Moneda>();
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetAllMoneda", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Moneda moneda = new Moneda(
                        Convert.ToInt32(reader["idMoneda"]),
                        reader["descripcion"].ToString(),
                        reader["codAFIP"].ToString()
                        );
                    result.Add(moneda);
                }

                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

    }
}

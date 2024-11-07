using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data
{
    public class DTipoCuenta
    {
        public static TipoCuenta GetById(int idTipoCuenta)
        {
            TipoCuenta result = new TipoCuenta();
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetByIDTipoCuenta", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idTipoCuenta", idTipoCuenta);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = new TipoCuenta(
                        Convert.ToInt32(reader["idTipoCuenta"]),
                        reader["descripcion"].ToString(),
                        Convert.ToInt32(reader["rubroPatrimonial"])
                        );
                }

                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public static List<TipoCuenta> GetAll()
        {
            List<TipoCuenta> result = new List<TipoCuenta>();
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetAllTipoCuenta", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TipoCuenta tipoCuenta = new TipoCuenta(
                        Convert.ToInt32(reader["idTipoCuenta"]),
                        reader["descripcion"].ToString(),
                        Convert.ToInt32(reader["rubroPatrimonial"])
                        );
                    result.Add(tipoCuenta);
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

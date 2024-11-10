using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data
{
    public class DCuenta
    {
        public static Cuenta GetById(int idCuenta)
        {
            Cuenta result = new Cuenta();
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetByIDCuenta", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idCuenta", idCuenta);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TipoCuenta tipoCuenta = DTipoCuenta.GetById(Convert.ToInt32(reader["codTipoCuenta"]));
                    result = new Cuenta(
                        Convert.ToInt32(reader["idCuenta"]),
                        reader["detalle"].ToString(),
                        reader["codigo"].ToString(),
                        tipoCuenta
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
        public static List<Cuenta> GetAll()
        {
            List<Cuenta> result = new List<Cuenta>();
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("GetAllCuenta", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TipoCuenta tipoCuenta = DTipoCuenta.GetById(Convert.ToInt32(reader["codTipoCuenta"]));
                    Cuenta cuenta = new Cuenta(
                        Convert.ToInt32(reader["idCuenta"]),
                        reader["detalle"].ToString(),
                        reader["codigo"].ToString(),
                        tipoCuenta
                        );
                    result.Add(cuenta);
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

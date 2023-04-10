using ApisContratos.Models;
using System.Data;
using System.Data.SqlClient;

namespace ApisContratos.Handlers
{
    public class Procedures
    {
        
       
        public R_WEB_Response getProcsRWeb()
        {
            var response = new R_WEB_Response();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TOP 1 * FROM R_Web WHERE ESTADO = 'Procesando'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using(SqlDataReader reader = command.ExecuteReader()) 
                        { 
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["MontPagadoCapital"]);
                                response.numero_operacion = reader["numero_operacion"] != System.DBNull.Value ? Convert.ToInt64(reader["numero_operacion"]) : 0;
                                response.Estado = reader["Estado"].ToString();
                            }
                        }

                    }
                }
                catch(Exception ex)
                {
                    throw;
                }
             
               
            }
            return response;
        }
    }
}

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

        public bool deleteRWeb(int id)
        {
            bool response;
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "DELETE FROM R_Web WHERE id ='"+id+"'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            

                                response = true;
                            
                        }

                    }
                }
                catch (Exception ex)
                {
                    response = false;
                    throw;
                    
                }


            }
            return response;
        }

        public bool updateEstadoContratos(int nroOperacion)
        {
            bool response;
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "UPDATE Contratos_Web SET Estado = 'Contrato Generado' WHERE numero_operacion = '"+nroOperacion+"'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {


                            response = true;

                        }

                    }
                }
                catch (Exception ex)
                {
                    response = false;
                    throw;

                }


            }
            return response;
        }

        public R_WEB_Response getContratosNumOp(int nroOp)
        {
            var response = new R_WEB_Response();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM Contratos_Web WHERE numero_operacion = '"+nroOp+"'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
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
                catch (Exception ex)
                {
                    throw;
                }


            }
            return response;
        }

        public REPRESENTANTES_LEGALES_Response getRepreJefeAg(string jefeAgencia)
        {
            var response = new REPRESENTANTES_LEGALES_Response();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Representantes_Legales] WHERE Nombre_Representante = '"+jefeAgencia+"'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //response.id = Convert.ToInt64(reader["MontPagadoCapital"]);
                                //response.numero_operacion = reader["numero_operacion"] != System.DBNull.Value ? Convert.ToInt64(reader["numero_operacion"]) : 0;
                                //response.Estado = reader["Estado"].ToString();
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    throw;
                }


            }
            return response;
        }
    }
}

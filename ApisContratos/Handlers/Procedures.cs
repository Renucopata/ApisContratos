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

        public CONTRATOS_WEB_Response getContratosNumOp(int nroOp)
        {
            var response = new CONTRATOS_WEB_Response();
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
                                response.id = Convert.ToInt64(reader["id"]);
                                response.Fecha_solicitud = Convert.ToDateTime(reader["Fecha_solicitud"]);
                                response.Usuario_Funcionario = reader["Usuario_Funcionario"].ToString();
                                response.Funcionario = reader["Funcionario"].ToString();
                                response.Sucursal = reader["Sucursal"].ToString();
                                response.Agencia = reader["Agencia"].ToString();
                                response.Jefe_Agencia = reader["Jefe_Agencia"].ToString();
                                response.numero_operacion = reader["numero_operacion"] != System.DBNull.Value ? Convert.ToInt64(reader["numero_operacion"]) : 0;
                                response.Tipo_Operacion = reader["Tipo_Operacion"].ToString();
                                response.Adjuntos = reader["Adjuntos"].ToString();
                                response.Asignado = reader["Asignado"].ToString();
                                response.Tipo_Contrato = reader["Tipo_Contrato"].ToString();
                                response.Estado = reader["Estado"].ToString();
                                response.Garantia = reader["Garantia"] != System.DBNull.Value ? Convert.ToInt64(reader["Garantia"]) : 0;
                                response.OficialC = reader["OficialC"] != System.DBNull.Value ? Convert.ToInt64(reader["OficialC"]) : 0;
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
                                response.IdTabla = Convert.ToInt64(reader["IdTabla"]);
                                response.Nombre_Representante = reader["Nombre_Representante"].ToString();
                                response.Domicilio_Representante = reader["Domicilio_Representante"].ToString();
                                response.CI_Lugar = reader["CI_Lugar"].ToString();
                                response.Calidad_Cargo = reader["Calidad_Cargo"].ToString();
                                response.Numero_Testimonio = reader["Numero_Testimonio"].ToString();
                                response.Fecha_Testimonio = reader["Fecha_Testimonio"].ToString();
                                response.Numero_Notario = reader["Numero_Notario"] != System.DBNull.Value ? Convert.ToInt64(reader["Numero_Notario"]) : 0;
                                response.Nombre_Notario = reader["Nombre_Notario"].ToString();
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

        public REPRESENTANTES_LEGALES_Response getGarantiasNumOp(int nroOp)
        {
            var response = new REPRESENTANTES_LEGALES_Response();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Garantias] WHERE numero_operacion_id = '"+nroOp+"'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.IdTabla = Convert.ToInt64(reader["IdTabla"]);
                                response.Nombre_Representante = reader["Nombre_Representante"].ToString();
                                response.Domicilio_Representante = reader["Domicilio_Representante"].ToString();
                                response.CI_Lugar = reader["CI_Lugar"].ToString();
                                response.Calidad_Cargo = reader["Calidad_Cargo"].ToString();
                                response.Numero_Testimonio = reader["Numero_Testimonio"].ToString();
                                response.Fecha_Testimonio = reader["Fecha_Testimonio"].ToString();
                                response.Numero_Notario = reader["Numero_Notario"] != System.DBNull.Value ? Convert.ToInt64(reader["Numero_Notario"]) : 0;
                                response.Nombre_Notario = reader["Nombre_Notario"].ToString();
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

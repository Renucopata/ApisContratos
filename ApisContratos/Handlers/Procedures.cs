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

        public List<REPRESENTANTES_LEGALES_Response> getRepreJefeAg(string jefeAgencia)
        {
            var responseList = new List<REPRESENTANTES_LEGALES_Response>();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Representantes_Legales] WHERE Nombre_Representante = '" + jefeAgencia + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (var adapter = new SqlDataAdapter(command))
                        {

                            var dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    var response = new REPRESENTANTES_LEGALES_Response();
                                    response.IdTabla = Convert.ToInt64(dt.Rows[i]["IdTabla"]);
                                    response.Nombre_Representante = dt.Rows[i]["Nombre_Representante"].ToString();
                                    response.Domicilio_Representante = dt.Rows[i]["Domicilio_Representante"].ToString();
                                    response.CI_Lugar = dt.Rows[i]["CI_Lugar"].ToString();
                                    response.Calidad_Cargo = dt.Rows[i]["Calidad_Cargo"].ToString();
                                    response.Numero_Testimonio = dt.Rows[i]["Numero_Testimonio"].ToString();
                                    response.Fecha_Testimonio = dt.Rows[i]["Fecha_Testimonio"].ToString();
                                    response.Numero_Notario = dt.Rows[i]["Numero_Notario"] != System.DBNull.Value ? Convert.ToInt64(dt.Rows[i]["Numero_Notario"]) : 0;
                                    response.Nombre_Notario = dt.Rows[i]["Nombre_Notario"].ToString();
                                    responseList.Add(response);

                                }

                            }


                        }
                    }


                }
                catch (Exception ex)
                {
                    throw;
                }


            }
            return responseList;
        }

        public GARANTIAS_Response getGarantiasNumOp(int nroOp)
        {
            var response = new GARANTIAS_Response();
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
                                response.id = Convert.ToInt64(reader["id"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.inmueble = Convert.ToInt64(reader["inmueble"]);
                                response.segunda_hipoteca = Convert.ToInt64(reader["segunda_hipoteca"]);
                                response.cancelacion_primera_hipoteca = Convert.ToInt64(reader["cancelacion_primera_hipoteca"]);
                                response.compra_deuda = Convert.ToInt64(reader["compra_deuda"]);
                                response.vehiculo = Convert.ToInt64(reader["vehiculo"]);
                                response.cancelacion_primera_hipoteca_vehiculo = Convert.ToInt64(reader["cancelacion_primera_hipoteca_vehiculo"]);
                                response.maquinaria_agricola = Convert.ToInt64(reader["maquinaria_agricola"]);
                                response.garantia_warrant = Convert.ToInt64(reader["garantia_warrant"]);
                                response.fianza = Convert.ToInt64(reader["fianza"]);
                                response.prendaria_sin_desplazamiento = Convert.ToInt64(reader["prendaria_sin_desplazamiento"]);
                                response.garantia_autoliquidable_dpf = Convert.ToInt64(reader["garantia_autoliquidable_dpf"]);
                                response.dpf_anotacion_cuenta = Convert.ToInt64(reader["dpf_anotacion_cuenta"]);
                                response.fondo_garantia = Convert.ToInt64(reader["fondo_garantia"]);
                                response.fogacp = Convert.ToInt64(reader["fogacp"]);
                                response.custodia_bienes_inmueble = Convert.ToInt64(reader["custodia_bienes_inmueble"]);
                                response.activos_no_sujetos = Convert.ToInt64(reader["activos_no_sujetos"]);
                                response.compromiso_venta_futuro = Convert.ToInt64(reader["compromiso_venta_futuro"]);
                                response.producto_almacenado = Convert.ToInt64(reader["producto_almacenado"]);
                                response.semoviente = Convert.ToInt64(reader["semoviente"]);
                                response.patente_propiedad_intelectual = Convert.ToInt64(reader["patente_propiedad_intelectual"]);
                                response.garantia_derechos_autor = Convert.ToInt64(reader["garantia_derechos_autor"]);
                                response.garantia_quirografaria = Convert.ToInt64(reader["garantia_quirografaria"]);
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

        public INMUEBLE_RESPONSE getInmuebleNoOp(int nroOp)
        {
            var response = new INMUEBLE_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Inmueble] WHERE numero_operacion_id ='"+nroOp+"'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.inmueble = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.propiedad_de = Convert.ToString(reader["propiedad_de"]);
                                response.ubicado_en = Convert.ToString(reader["ubicado_en"]);
                                response.extension_superficie = Convert.ToInt64(reader["extension_superficie"]);
                                response.norte = Convert.ToString(reader["norte"]);
                                response.sur = Convert.ToString(reader["sur"]);
                                response.este = Convert.ToString(reader["este"]);
                                response.oeste = Convert.ToString(reader["oeste"]);
                                response.adquirido_por = Convert.ToString(reader["adquirido_por"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.departamento = Convert.ToString(reader["departamento"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.oficina_derechos_reales = Convert.ToString(reader["oficina_derechos_reales"]);
                                response.nro_codigo_catastral = Convert.ToString(reader["nro_codigo_catastral"]);
                                response.senor = Convert.ToString(reader["senor"]);
                                response.ci = Convert.ToString(reader["ci"]);
                                response.estado_civil = Convert.ToString(reader["estado_civil"]);
                                response.nacionalidad = Convert.ToString(reader["nacionalidad"]);
                                response.domicilio = Convert.ToString(reader["domicilio"]);
                                response.nro_domicilio = Convert.ToString(reader["nro_domicilio"]);
                                response.estado_civil_conyugue = Convert.ToString(reader["estado_civil_conyugue"]);
                                response.nacionalidad_conyugue = Convert.ToString(reader["nacionalidad_conyugue"]);
                                response.domicilio_conyugue = Convert.ToString(reader["domicilio_conyugue"]);
                                response.nro_domicilio_conyugue = Convert.ToString(reader["nro_domicilio_conyugue"]);
                                response.zona = Convert.ToString(reader["zona"]);
                               
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

        public SEGUNDA_HIPOTECA_RESPONSE GetHipoByNoOp(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Segunda_Hipoteca] WHERE numero_operacion_id ='"+nroOp+"'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);
                          
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

        public SEGUNDA_HIPOTECA_RESPONSE getCancelacionHipo(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM[BDD_Contratos].[dbo].[Cancelacion_Hipoteca] WHERE numero_operacion_id ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);

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

        public SEGUNDA_HIPOTECA_RESPONSE getCompraDeuda(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Compra_Deuda] WHERE numero_operacion_id ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);

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

        public SEGUNDA_HIPOTECA_RESPONSE getVehiculo(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Vehiculo] WHERE numero_operacion_id ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);

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

        public SEGUNDA_HIPOTECA_RESPONSE getCancelahipoVehiculo(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Cancelacion_Hipoteca_Vehiculo] WHERE numero_operacion_id ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);

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

        public SEGUNDA_HIPOTECA_RESPONSE getMaquinaAgri(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Maquinaria_Agricola] WHERE numero_operacion_id ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);

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

        public SEGUNDA_HIPOTECA_RESPONSE getGarantiaWarrant(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Garantia_Warrant] WHERE numero_operacion_id ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);

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

        public SEGUNDA_HIPOTECA_RESPONSE getFianza(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Fianza] WHERE numero_operacion_id ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);

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

        public SEGUNDA_HIPOTECA_RESPONSE getPrendaria(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Prendaria] WHERE numero_operacion_id ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);

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

        public SEGUNDA_HIPOTECA_RESPONSE getGarantiaAutiLiquiDPF(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Garantia_Autoliquidable_Dpf] WHERE numero_operacion_id ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);

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

        public SEGUNDA_HIPOTECA_RESPONSE getDPFAnotacionCuenta(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Dpf_Anotacion_Cuenta] WHERE numero_operacion_id ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);

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

        public SEGUNDA_HIPOTECA_RESPONSE getFondoGarantia(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Fondo_Garantia] WHERE numero_operacion_id ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);

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

        public SEGUNDA_HIPOTECA_RESPONSE getFOGACP(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[FOGACP] WHERE numero_operacion_id ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);

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

        public SEGUNDA_HIPOTECA_RESPONSE getCustodiabienesInmueble(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Custodia_Bienes_Inmueble] WHERE numero_operacion_id ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);

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

        public SEGUNDA_HIPOTECA_RESPONSE getActivosNoSujetos(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Activos_No_Sujetos] WHERE numero_operacion_id ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);

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

        public SEGUNDA_HIPOTECA_RESPONSE getProductoAlmacenado(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Producto_Almacenado] WHERE numero_operacion_id ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);

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

        public SEGUNDA_HIPOTECA_RESPONSE getSemoviente(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Semoviente] WHERE numero_operacion_id ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);

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

        public SEGUNDA_HIPOTECA_RESPONSE getPatentePropiedadIntelec(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Patente_Propiedad_Intelectual] WHERE numero_operacion_id ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);

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

        public SEGUNDA_HIPOTECA_RESPONSE getGarantiaDereAutor(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Garantia_Derecho_Autor] WHERE numero_operacion_id ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);

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

        public SEGUNDA_HIPOTECA_RESPONSE getCompromiVentaFuturo(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM [BDD_Contratos].[dbo].[Compromiso_Venta_Futuro] WHERE numero_operacion_id ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);

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

        public SEGUNDA_HIPOTECA_RESPONSE getAsignados(int nroOp)
        {
            var response = new SEGUNDA_HIPOTECA_RESPONSE();
            var cn = new ContratosConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT Correos_Asignados FROM [BDD_Contratos].[dbo].[Asignados] WHERE Asignado ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.hipoteca = Convert.ToString(reader["inmueble"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.fecha_tramite = Convert.ToDateTime(reader["fecha_tramite"]);

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

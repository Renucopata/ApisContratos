using ApisContratos.Models;
using System.Data;
using System.Data.SqlClient;

namespace ApisContratos.Handlers
{
    public class Procedures
    {
        
       
        public R_WEB_RESPONSE getProcsRWeb()
        {
            var response = new R_WEB_RESPONSE();
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

        public CONTRATOS_WEB_RESPONSE getContratosNumOp(int nroOp)
        {
            var response = new CONTRATOS_WEB_RESPONSE();
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

        public List<REPRESENTANTES_LEGALES_RESPONSE> getRepreJefeAg(string jefeAgencia)
        {
            var responseList = new List<REPRESENTANTES_LEGALES_RESPONSE>();
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
                                    var response = new REPRESENTANTES_LEGALES_RESPONSE();
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

        public GARANTIAS_RESPONSE getGarantiasNumOp(int nroOp)
        {
            var response = new GARANTIAS_RESPONSE();
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

        public CANCELACION_HIPOTECA getCancelacionHipo(int nroOp)
        {
            var response = new CANCELACION_HIPOTECA();
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
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha_notario = Convert.ToDateTime(reader["fecha_notario"]);

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

        public COMPRA_DEUDA getCompraDeuda(int nroOp)
        {
            var response = new COMPRA_DEUDA();
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
                                response.asiento = Convert.ToString(reader["asiento"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.nro_tramite = Convert.ToInt64(reader["nro_tramite"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);       
                                response.fecha_notario = Convert.ToDateTime(reader["fecha_notario"]);

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

        public VEHICULO_RESPONSE getVehiculo(int nroOp)
        {
            var response = new VEHICULO_RESPONSE();
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
                                response.propiedad_de = Convert.ToString(reader["propiedad_de"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.marca = Convert.ToString(reader["marca"]);
                                response.clase = Convert.ToString(reader["clase"]);
                                response.placa = Convert.ToString(reader["placa"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.nro_chasis = Convert.ToString(reader["nro_chasis"]);
                                response.nro_motor = Convert.ToString(reader["nro_motor"]);
                                response.modelo = Convert.ToString(reader["modelo"]);
                                response.persona_vehiculo = Convert.ToString(reader["persona_vehiculo"]);
                                response.ci = Convert.ToString(reader["ci"]);
                                response.estado_civil = Convert.ToString(reader["estado_civil"]);
                                response.nacionalidad = Convert.ToString(reader["nacionalidad"]);
                                response.domicilio = Convert.ToString(reader["domicilio"]);
                                response.persona_vehiculo_dos = Convert.ToString(reader["persona_vehiculo_dos"]);
                                response.ci_dos = Convert.ToString(reader["ci_dos"]);
                                response.estado_civil_dos = Convert.ToString(reader["estado_civil_dos"]);
                                response.nacionalidad_dos = Convert.ToString(reader["nacionalidad_dos"]);
                                response.domicilio_dos = Convert.ToString(reader["domicilio_dos"]);
                                response.persona_conyugue = Convert.ToString(reader["persona_conyugue"]);
                                response.ci_conyugue = Convert.ToString(reader["ci_conyugue"]);
                                response.estado_civil_conyugue = Convert.ToString(reader["estado_civil_conyugue"]);
                                response.nacionalidad_conyugue = Convert.ToString(reader["nacionalidad_conyugue"]);
                                response.domicilio_conyugue = Convert.ToString(reader["domicilio_conyugue"]);
                                response.nro_domicilio = Convert.ToString(reader["nro_domicilio"]);
                                response.nro_domicilio_dos = Convert.ToString(reader["nro_domicilio_dos"]);
                                response.nro_domicilio_conyugue = Convert.ToString(reader["nro_domicilio_conyugue"]);

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

        public CANCELACION_HIPOTECA_VEHIC_RESPONSE getCancelahipoVehiculo(int nroOp)
        {
            var response = new CANCELACION_HIPOTECA_VEHIC_RESPONSE();
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
                                response.nro_hoja_ruta = Convert.ToString(reader["nro_hoja_ruta"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.nro_escritura_publica = Convert.ToString(reader["nro_escritura_publica"]);
                                response.notario = Convert.ToString(reader["notario"]);
                                response.fecha_notario = Convert.ToDateTime(reader["fecha"]);


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

        public MAQUINARIA_AGRICOLA_RESPONSE getMaquinaAgri(int nroOp)
        {
            var response = new MAQUINARIA_AGRICOLA_RESPONSE();
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
                                response.propepiedad_de = Convert.ToString(reader["propepiedad_de"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.caracteristicas = Convert.ToString(reader["caracteristicas"]);
                                response.registrado = Convert.ToString(reader["registrado"]);
                                response.registro = Convert.ToString(reader["registro"]);
                                response.fojas = Convert.ToString(reader["fojas"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.senor = Convert.ToString(reader["senor"]);
                                response.ci = Convert.ToString(reader["ci"]);
                                response.estado_civil = Convert.ToString(reader["estado_civil"]);
                                response.nacionalidad = Convert.ToString(reader["nacionalidad"]);
                                response.domicilio = Convert.ToString(reader["domicilio"]);

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

        public GARANTIA_WARRANT_RESPONSE getGarantiaWarrant(int nroOp)
        {
            var response = new GARANTIA_WARRANT_RESPONSE();
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
                                response.nro_prenda = Convert.ToString(reader["nro_prenda"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.emitido = Convert.ToString(reader["emitido"]);
                                response.fecha_inicio = Convert.ToDateTime(reader["fecha_inicio"]);
                                response.fecha_vencimiento = Convert.ToDateTime(reader["fecha_vencimiento"]);
                                response.vigencia = Convert.ToString(reader["vigencia"]);
                                response.dias_vigencia = Convert.ToString(reader["dias_vigencia"]);
                                response.valor = Convert.ToDecimal(reader["valor"]);
                                response.meses = Convert.ToString(reader["meses"]);
                                response.numero = Convert.ToString(reader["numero"]);
                                response.precio_promedio = Convert.ToString(reader["precio_promedio"]);
                                response.precio = Convert.ToDecimal(reader["precio"]);
                                response.empresa = Convert.ToString(reader["empresa"]);
                                response.endoso = Convert.ToString(reader["endoso"]);

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

        public FIANZA_RESPONSE getFianza(int nroOp)
        {
            var response = new FIANZA_RESPONSE();
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
                                response.senor = Convert.ToString(reader["senor"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.ci = Convert.ToString(reader["ci"]);
                                response.domicilio = Convert.ToString(reader["domicilio"]);
                                response.estado_civil = Convert.ToString(reader["estado_civil"]);
                                response.nacionalidad = Convert.ToString(reader["nacionalidad"]);

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

        public PRENDARIA_RESPONSE getPrendaria(int nroOp)
        {
            var response = new PRENDARIA_RESPONSE();
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
                                response.detalle = Convert.ToString(reader["detalle"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.senor = Convert.ToString(reader["senor"]);
                                response.domicilio = Convert.ToString(reader["domicilio"]);

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

        public GARANTIA_AUTOLIQUI_DPF_RESPONSE getGarantiaAutiLiquiDPF(int nroOp)
        {
            var response = new GARANTIA_AUTOLIQUI_DPF_RESPONSE();
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
                                response.numero = Convert.ToInt64(reader["numero"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.moneda = Convert.ToString(reader["moneda"]);
                                response.monto = Convert.ToDecimal(reader["monto"]);
                                response.fecha_emision = Convert.ToDateTime(reader["fecha_emision"]);
                                response.fecha_vencimiento = Convert.ToDateTime(reader["fecha_vencimiento"]);
                                response.a_favor = Convert.ToString(reader["a_favor"]);
                                response.plazo = Convert.ToString(reader["plazo"]);

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

        public DPF_ANOTACION_CUENTA_RESPONSE getDPFAnotacionCuenta(int nroOp)
        {
            var response = new DPF_ANOTACION_CUENTA_RESPONSE();
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
                                response.nombre_ordenante = Convert.ToString(reader["nombre_ordenante"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.entidad_financiera = Convert.ToString(reader["entidad_financiera"]);
                                response.nombre_entidad_financiera = Convert.ToString(reader["nombre_entidad_financiera"]);
                                response.numero = Convert.ToInt64(reader["numero"]);
                                response.suma = Convert.ToDecimal(reader["suma"]);
                                response.cuenta = Convert.ToString(reader["cuenta"]);

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

        public FONDO_GARANTIA_RESPONSE getFondoGarantia(int nroOp)
        {
            var response = new FONDO_GARANTIA_RESPONSE();
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
                                response.fondo_garantia = Convert.ToString(reader["fondo_garantia"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.porcentaje = Convert.ToString(reader["porcentaje"]);
                                response.numero_porcentaje = Convert.ToDecimal(reader["numero_porcentaje"]);
                                response.mora = Convert.ToString(reader["mora"]);
                                response.monto = Convert.ToDecimal(reader["monto"]);

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

        public FOGACP_RESPONSE getFOGACP(int nroOp)
        {
            var response = new FOGACP_RESPONSE();
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
                                response.monto_total = Convert.ToDecimal(reader["monto_total"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.tipo_amortizacion = Convert.ToString(reader["tipo_amortizacion"]);
                                response.porcentaje = Convert.ToString(reader["porcentaje"]);
                                response.numero_porcentaje = Convert.ToDecimal(reader["numero_porcentaje"]);
                                response.monto = Convert.ToDecimal(reader["monto"]);
                                response.sector = Convert.ToString(reader["sector"]);

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

        public CUSTODIA_BIENES_INMUEBLE_RESPONSE getCustodiabienesInmueble(int nroOp)
        {
            var response = new CUSTODIA_BIENES_INMUEBLE_RESPONSE();
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
                                response.nombre = Convert.ToString(reader["nombre"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.calidad = Convert.ToString(reader["calidad"]);
                             

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

        public ACTIVOS_NO_SUJETOS_RESPONSE getActivosNoSujetos(int nroOp)
        {
            var response = new ACTIVOS_NO_SUJETOS_RESPONSE();
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
                                response.nombre_depositario = Convert.ToString(reader["nombre_depositario"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.domicilio = Convert.ToString(reader["domicilio"]);
                                response.calidad = Convert.ToString(reader["calidad"]);
                      
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

        public PRODUCTO_ALMACENADO_RESPONSE getProductoAlmacenado(int nroOp)
        {
            var response = new PRODUCTO_ALMACENADO_RESPONSE();
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
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.senor = Convert.ToString(reader["senor"]);
                                response.ci = Convert.ToString(reader["ci"]);
                                response.plazo = Convert.ToString(reader["plazo"]);
                                response.domicilio = Convert.ToString(reader["domicilio"]);
                                response.ciudad = Convert.ToString(reader["ciudad"]);
  
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

        public SEMOVIENTE_RESPONSE getSemoviente(int nroOp)
        {
            var response = new SEMOVIENTE_RESPONSE();
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
                                response.nombre = Convert.ToString(reader["nombre"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.domicilio = Convert.ToString(reader["domicilio"]);
                                response.numero = Convert.ToInt64(reader["numero"]);
                                response.especie = Convert.ToString(reader["especie"]);
                                response.raza = Convert.ToString(reader["raza"]);
                                response.sexo = Convert.ToString(reader["sexo"]);
                                response.peso = Convert.ToDecimal(reader["peso"]);
                                response.edad = Convert.ToString(reader["edad"]);
                                response.color = Convert.ToString(reader["color"]);
                                response.marcas_señales_ = Convert.ToString(reader["marcas_señales_"]);

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

        public PATENTE_PROPIEDAD_INTELEC_RESPONSE getPatentePropiedadIntelec(int nroOp)
        {
            var response = new PATENTE_PROPIEDAD_INTELEC_RESPONSE();
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
                                response.numero_certificado = Convert.ToInt64(reader["numero_certificado"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.correspondiendo = Convert.ToString(reader["correspondiendo"]);
                                response.tipo = Convert.ToString(reader["tipo"]);
                                response.clase = Convert.ToString(reader["clase"]);
                                response.numero_registro = Convert.ToInt64(reader["numero_registro"]);
                                response.numero_resolucion = Convert.ToInt64(reader["numero_resolucion"]);
                                response.registro = Convert.ToString(reader["registro"]);


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

        public GARANTIA_DERECHO_AUTOR_RESPONSE getGarantiaDereAutor(int nroOp)
        {
            var response = new GARANTIA_DERECHO_AUTOR_RESPONSE();
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
                                response.numero_resolucion = Convert.ToInt64(reader["numero_resolucion"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.fecha = Convert.ToDateTime(reader["fecha"]);

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

        public COMPROMISO_VENTA_FUTURO_RESPONSE getCompromiVentaFuturo(int nroOp)
        {
            var response = new COMPROMISO_VENTA_FUTURO_RESPONSE();
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
                                response.fecha = Convert.ToDateTime(reader["fecha"]);
                                response.numero_operacion_id = Convert.ToInt64(reader["numero_operacion_id"]);
                                response.senor = Convert.ToString(reader["senor"]);
                                response.productos = Convert.ToString(reader["productos"]);
                                response.fecha_dos = Convert.ToDateTime(reader["fecha_dos"]);

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

        public ASIGNADOS_RESPONSE getAsignados(int nroOp) //No hay correos asignados en la base de asignados
        {
            var response = new ASIGNADOS_RESPONSE();
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
                                response.Asignado = Convert.ToString(reader["Asignado"]);

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
         //Servidor: 254 satge
        public ASIGNADOS_RESPONSE getgeneral_prmpr(int nroOp) //No hay correos asignados en la base de asignados
        {
            var response = new ASIGNADOS_RESPONSE();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "select gbagenomb,* from general.prmpr left join gbage on gbagecage = prmprcage where prmprnpre='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.Asignado = Convert.ToString(reader["Asignado"]);

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

        public ASIGNADOS_RESPONSE getgbage(int codigo) //No hay correos asignados en la base de asignados
        {
            var response = new ASIGNADOS_RESPONSE();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "select gbagendid, gbageeciv, gbagenaci, gbageddo1, gbageddo2 from gbage where gbagecage ='" + codigo + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.Asignado = Convert.ToString(reader["Asignado"]);

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

        public ASIGNADOS_RESPONSE getTempCartera(int nroOp) //No hay correos asignados en la base de asignados
        {
            var response = new ASIGNADOS_RESPONSE();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "select gbagenomb, prdeucage, prdeutres from TempCartera.prdeu left join gbage on gbagecage = prdeucage where prdeunpre= '{numero_operacion}' and prdeucage not in (select prmprcage from general.prmpr where prmprnpre='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.Asignado = Convert.ToString(reader["Asignado"]);

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

        public ASIGNADOS_RESPONSE getbagecage(int codigo) //No hay correos asignados en la base de asignados
        {
            var response = new ASIGNADOS_RESPONSE();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "select gbagendid, gbageeciv, gbagenaci, gbageddo1, gbageddo2 from gbage where gbagecage ='" + codigo + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.Asignado = Convert.ToString(reader["Asignado"]);

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

        public ASIGNADOS_RESPONSE getprmprnpre(int nroOp) //No hay correos asignados en la base de asignados
        {
            var response = new ASIGNADOS_RESPONSE();
            var cn = new StageConnection();
            using (var conexion = new SqlConnection(cn.get_cadConexion()))
            {
                try
                {
                    conexion.Open();
                    string query = "select prmprcmon, prmprmdes, prmprlncr from general.prmpr where prmprnpre ='" + nroOp + "'";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                response.id = Convert.ToInt64(reader["id"]);
                                response.Asignado = Convert.ToString(reader["Asignado"]);

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

namespace ApisContratos.Models
{
    public class Response
    {

    }

    public class R_WEB_RESPONSE
    {
        public Int64 id { get; set; }
        public Int64 numero_operacion { get; set; }
        public string Estado { get; set; }
    }

    public class REPRESENTANTES_LEGALES_RESPONSE
    {
        public Int64 IdTabla { get; set; }
        public string Nombre_Representante { get; set; }
        public string Domicilio_Representante { get; set; }
        public string CI_Lugar { get; set; }
        public string Calidad_Cargo { get; set; }
        public string Numero_Testimonio { get; set; }
        public string Fecha_Testimonio { get; set; }
        public float Numero_Notario { get; set; }
        public string Nombre_Notario { get; set; }

    }

    public class CONTRATOS_WEB_RESPONSE
    {
        public Int64 id { get; set; }
        public DateTime Fecha_solicitud { get; set; }
        public string Usuario_Funcionario { get; set; }
        public string Funcionario { get; set; }
        public string Sucursal { get; set; }
        public string Agencia { get; set; }
        public string Jefe_Agencia { get; set; }
        public Int64 numero_operacion { get; set; }
        public string Tipo_Operacion { get; set; }
        public string Adjuntos { get; set; }
        public string Asignado { get; set; }
        public string Tipo_Contrato { get; set; }
        public string Estado { get; set; }
        public Int64 Garantia { get; set; } //Bit en la tabla
        public Int64 OficialC { get; set; }
       
    }

    public class GARANTIAS_RESPONSE
    {
        public Int64 id { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public Int64 inmueble { get; set; }
        public Int64 segunda_hipoteca { get; set; }
        public Int64 cancelacion_primera_hipoteca { get; set; }
        public Int64 compra_deuda { get; set; }
        public Int64 vehiculo { get; set; }
        public Int64 cancelacion_primera_hipoteca_vehiculo { get; set; }
        public Int64 maquinaria_agricola { get; set; }
        public Int64 garantia_warrant { get; set; }
        public Int64 fianza { get; set; }
        public Int64 prendaria_sin_desplazamiento { get; set; }
        public Int64 garantia_autoliquidable_dpf { get; set; }
        public Int64 dpf_anotacion_cuenta { get; set; } //Bit en la tabla
        public Int64 fondo_garantia { get; set; }
        public Int64 fogacp { get; set; }
        public Int64 custodia_bienes_inmueble { get; set; }
        public Int64 activos_no_sujetos { get; set; }
        public Int64 compromiso_venta_futuro { get; set; }
        public Int64 producto_almacenado { get; set; }
        public Int64 semoviente { get; set; }
        public Int64 patente_propiedad_intelectual { get; set; }
        public Int64 garantia_derechos_autor { get; set; }
        public Int64 garantia_quirografaria { get; set; }

    }

    public class INMUEBLE_RESPONSE
    {
        public Int64 id { get; set; }
        public string inmueble { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public string propiedad_de { get; set; }
        public string ubicado_en { get; set; }
        public Int64 extension_superficie { get; set; }
        public string norte { get; set; }
        public string sur { get; set; }
        public string este { get; set; }
        public string oeste { get; set; }
        public string adquirido_por { get; set; }
        public string nro_escritura_publica { get; set; }
        public string departamento { get; set; }
        public string notario { get; set; }
        public string oficina_derechos_reales { get; set; }
        public string nro_codigo_catastral { get; set; }
        public string senor { get; set; }
        public string ci { get; set; }
        public string estado_civil { get; set; }
        public string nacionalidad { get; set; }
        public string domicilio { get; set; }
        public string nro_domicilio { get; set; }
        public string ci_conyugue { get; set; }
        public string estado_civil_conyugue { get; set; }
        public string nacionalidad_conyugue { get; set; }
        public string domicilio_conyugue { get; set; }
        public string nro_domicilio_conyugue { get; set; }
        public string zona { get; set; }
    }

    public class SEGUNDA_HIPOTECA_RESPONSE
    {
        public Int64 id { get; set; }
        public string hipoteca { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public string asiento { get; set; }
        public Int64 nro_tramite { get; set; }
        public string nro_escritura_publica { get; set; }
        public string notario { get; set; }
        public DateTime fecha { get; set; }
        public DateTime fecha_tramite { get; set; }
    }

    public class CANCELACION_HIPOTECA
    {
        public Int64 id { get; set; }
        public string hipoteca { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public string asiento { get; set; }
        public Int64 nro_tramite { get; set; }
        public DateTime fecha { get; set; }
        public string nro_escritura_publica { get; set; }
        public string notario { get; set; }
        public DateTime fecha_notario { get; set; }
    }

    public class COMPRA_DEUDA
    {
        public Int64 id { get; set; }
        public string asiento { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public Int64 nro_tramite { get; set; }
        public DateTime fecha { get; set; }
        public string nro_escritura_publica { get; set; }
        public string notario { get; set; }
        public DateTime fecha_notario { get; set; }
    }

    public class VEHICULO_RESPONSE
    {
        public Int64 id { get; set; }
        public string propiedad_de { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public string marca { get; set; }
        public string clase { get; set; }
        public string placa { get; set; }
        public DateTime fecha { get; set; }
        public string nro_chasis { get; set; }
        public string nro_motor { get; set; }
        public string modelo { get; set; }
        public string persona_vehiculo { get; set; }
        public string ci { get; set; }
        public string estado_civil { get; set; }
        public string nacionalidad { get; set; }
        public string domicilio { get; set; }
        public string persona_vehiculo_dos { get; set; }
        public string ci_dos { get; set; }
        public string estado_civil_dos { get; set; }
        public string nacionalidad_dos { get; set; }
        public string domicilio_dos { get; set; }
        public string persona_conyugue { get; set; }
        public string ci_conyugue { get; set; }
        public string estado_civil_conyugue { get; set; }
        public string nacionalidad_conyugue { get; set; }
        public string domicilio_conyugue { get; set; }
        public string nro_domicilio { get; set; }
        public string nro_domicilio_dos { get; set; }
        public string nro_domicilio_conyugue { get; set; }
    }

    public class CANCELACION_HIPOTECA_VEHIC_RESPONSE
    {
        public Int64 id { get; set; }
        public string nro_hoja_ruta { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public DateTime fecha { get; set; }
        public string nro_escritura_publica { get; set; }
        public string notario { get; set; }
        public DateTime fecha_notario { get; set; }
    }

    public class MAQUINARIA_AGRICOLA_RESPONSE
    {
        public Int64 id { get; set; }
        public string propepiedad_de { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public string caracteristicas { get; set; }
        public string registrado { get; set; }
        public string registro { get; set; }
        public string fojas { get; set; }
        public DateTime fecha { get; set; }
        public string senor { get; set; }
        public string ci { get; set; }
        public string estado_civil { get; set; }
        public string nacionalidad { get; set; }
        public string domicilio { get; set; }
    }

    public class GARANTIA_WARRANT_RESPONSE
    {
        public Int64 id { get; set; }
        public string nro_prenda { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public string emitido { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public string vigencia { get; set; }
        public string dias_vigencia { get; set; }
        public Decimal valor { get; set; }
        public string meses { get; set; }
        public string numero { get; set; }
        public string precio_promedio { get; set; }
        public Decimal precio { get; set; }
        public string empresa { get; set; }
        public string endoso { get; set; }
    }

    public class FIANZA_RESPONSE
    {
        public Int64 id { get; set; }
        public string senor { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public string ci { get; set; }
        public string domicilio { get; set; }
        public string estado_civil { get; set; }
        public string nacionalidad { get; set; }
       
    }

    public class PRENDARIA_RESPONSE
    {
        public Int64 id { get; set; }
        public string detalle { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public string senor { get; set; }
        public string domicilio { get; set; }

    }

}


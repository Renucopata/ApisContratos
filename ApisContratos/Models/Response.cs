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

    public class GARANTIA_AUTOLIQUI_DPF_RESPONSE
    {
        public Int64 id { get; set; }
        public Int64 numero { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public string moneda { get; set; }
        public Decimal monto { get; set; }
        public DateTime fecha_emision { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public string a_favor { get; set; }
        public string plazo { get; set; }

    }

    public class DPF_ANOTACION_CUENTA_RESPONSE
    {
        public Int64 id { get; set; }
        public string nombre_ordenante { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public string entidad_financiera { get; set; }
        public string nombre_entidad_financiera { get; set; }
        public Int64 numero { get; set; }
        public Decimal suma { get; set; }
        public string cuenta { get; set; }
    }

    public class FONDO_GARANTIA_RESPONSE
    {
        public Int64 id { get; set; }
        public string fondo_garantia { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public string porcentaje { get; set; }
        public Decimal numero_porcentaje { get; set; }
        public string mora { get; set; }
        public Decimal monto { get; set; }
    }

    public class FOGACP_RESPONSE
    {
        public Int64 id { get; set; }
        public Decimal monto_total { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public string tipo_amortizacion { get; set; }
        public string porcentaje { get; set; }
        public Decimal numero_porcentaje { get; set; }
        public Decimal monto { get; set; }
        public string sector { get; set; }
    }

    public class CUSTODIA_BIENES_INMUEBLE_RESPONSE
    {
        public Int64 id { get; set; }
        public string nombre { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public string calidad { get; set; }
       
    }
    public class ACTIVOS_NO_SUJETOS_RESPONSE
    {
        public Int64 id { get; set; }
        public string nombre_depositario { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public string domicilio { get; set; }
        public string calidad { get; set; }

    }

    public class PRODUCTO_ALMACENADO_RESPONSE
    {
        public Int64 id { get; set; }
        public DateTime fecha { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public string senor { get; set; }
        public string ci { get; set; }
        public string plazo { get; set; }
        public string domicilio { get; set; }
        public string ciudad { get; set; }

    }

    public class PATENTE_PROPIEDAD_INTELEC_RESPONSE
    {
        public Int64 id { get; set; }
        public Int64 numero_certificado { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public DateTime fecha { get; set; }
        public string correspondiendo { get; set; }
        public string tipo { get; set; }
        public string clase { get; set; }
        public Int64 numero_registro { get; set; }
        public Int64 numero_resolucion{ get; set; }
        public string registro { get; set; }

    }

    public class SEMOVIENTE_RESPONSE
    {
        public Int64 id { get; set; }
        public string nombre { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public string domicilio { get; set; }
        public Int64 numero { get; set; }
        public string especie { get; set; }
        public string raza { get; set; }
        public string sexo { get; set; }
        public Decimal peso { get; set; }
        public string edad { get; set; }
        public string color { get; set; }
        public string marcas_señales_ { get; set; }

    }

    public class GARANTIA_DERECHO_AUTOR_RESPONSE
    {
        public Int64 id { get; set; }
        public Int64 numero_resolucion { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public DateTime fecha { get; set; }  

    }

    public class COMPROMISO_VENTA_FUTURO_RESPONSE
    {
        public Int64 id { get; set; }
        public DateTime fecha { get; set; }
        public Int64 numero_operacion_id { get; set; }
        public string senor { get; set; }
        public string productos { get; set; }
        public DateTime fecha_dos { get; set; }

    }


    public class ASIGNADOS_RESPONSE
    {
        public Int64 id { get; set; }
        public string Asignado { get; set; }

    }

    public class GBAGENOMB_PRMPR_RESPONSE
    {
        public Int64 prmprnpre { get; set; }
        public Int64 prmprcage { get; set; }
        public string prmprfreg { get; set; }
        public string prmprnctr { get; set; }
        public Int64 prmprlncr { get; set; }
        public string prmprreso { get; set; }
        public Int64 prmprtcre { get; set; }
        public Int64 prmprorgr { get; set; }
        public Int64 prmprautp { get; set; }
        public Int64 prmprrseg { get; set; }
        public Int64 prmprconv { get; set; }
        public Int64 prmprrubr { get; set; }
        public Int64 prmprciiu { get; set; }
        public Int64 prmprdest { get; set; }
        public string prmprddes { get; set; }
        public Int64 prmprcmon { get; set; }
        public Int64 prmprmapt { get; set; }
        public Int64 prmprplzo { get; set; }
        public Int64 prmpruplz { get; set; }
        public Int64 prmprtsex { get; set; }
        public Int64 prmprfpag { get; set; }
        public Int64 prmprppgk { get; set; }
        public Int64 prmprppgi { get; set; }
        public Int64 prmprgrac { get; set; }
        public Int64 prmpruppg { get; set; }
        public Int64 prmprdiap { get; set; }
        public string prmprfprp { get; set; }
        public Int64 prmpriupg { get; set; }
        public Int64 prmprsald { get; set; }
        public Int64 prmprkven { get; set; }
        public Int64 prmprmdes { get; set; }
        public Int64 prmprmseg { get; set; }
        public Int64 prmprstat { get; set; }
        public string prmprfsta { get; set; }
        public string prmprfpvc { get; set; }
        public string prmprfvac { get; set; }
        public string prmprfvor { get; set; }
        public Int64 prmprstan { get; set; }
        public string prmprfsan { get; set; }
        public string prmprfdes { get; set; }
        public string prmprfulp { get; set; }
        public Int64 prmprfcal { get; set; }
        public string prmprcalf { get; set; }
        public Int64 prmprviad { get; set; }
        public string prmprctad { get; set; }
        public Int64 prmprviac { get; set; }
        public string prmprctac { get; set; }
        public string prmprdeba { get; set; }
        public Int64 prmprcrpg { get; set; }
        public string prmprfrpg { get; set; }
        public Int64 prmprpdvg { get; set; }
        public Int64 prmprpsus { get; set; }
        public string prmprfdev { get; set; }
        public char prmprmcpd { get; set; }
        public char prmprreve { get; set; }
        public string prmprusrr { get; set; }
        public Int64 prmprmrcb { get; set; }
        public Int64 prmprplaz { get; set; }
        public Int64 prmpragen { get; set; }
        public string prmpruser { get; set; }
        public string prmprhora { get; set; }
        public string prmprfpro { get; set; }
        public Int64 prmprcclf { get; set; }
        public Int64 prmprcpac { get; set; }
        public Int64 prmprnlex { get; set; }
        public Int64 prmprnmod { get; set; }
        public string prmprfinc { get; set; }
        public Int64 prmprnatu { get; set; }
        public Int64 prmprnprp { get; set; }
        public Int64 prmprctpp { get; set; }
        public Int64 prmprcbnq { get; set; }
        public Int64 prmprnrpg { get; set; }
        public Int64 prmprpais { get; set; }
        public Int64 prmprdpto { get; set; }
        public Int64 prmprcprv { get; set; }
        public Int64 prmprciud { get; set; }
        public Int64 prmprzona { get; set; }
        public Int64 prmprcmun { get; set; }
        public Int64 prmprambg { get; set; }
        public Int64 prmprcgta { get; set; }
        public Int64 prmprugps { get; set; }
        public Int64 prmprlong { get; set; }
        public Int64 prmprlati { get; set; }
        public Int64 prmprnfam { get; set; }


    }


}


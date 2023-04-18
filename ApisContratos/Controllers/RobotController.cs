using ApisContratos.Handlers;
using ApisContratos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApisContratos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RobotController : ControllerBase
    {

        [HttpGet] //Terminada no hay data para probar "R_Web"
        [Route("GetAllProcRWeb")]
        public IActionResult getProcRweb()
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getProcsRWeb());
        }

        [HttpPost] //Terminada no hay data para probar "R_Web"
        [Route("DeleteProcRWeb")]
        public IActionResult getProcRweb([FromBody] REQUEST_ID data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.deleteRWeb(data.id));
        }

        [HttpPost] // Terminada y probada
        [Route("UpdateEstadoContratos")]
        public IActionResult updateEstadoCon([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.updateEstadoContratos(data.NroOperacion));
        }

        [HttpPost] // Terminada y probada
        [Route("GetContratosByNumOp")]
        public IActionResult GetContratosByNumOp([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getContratosNumOp(data.NroOperacion));
        }

        [HttpPost] // Terminada y probada
        [Route("GetRepreLegalByJefeAg")]
        public IActionResult GetRepreByJefeAg([FromBody] REQUEST_JEFE_AGENCIA data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getRepreJefeAg(data.jefeAgencia));
        }

        [HttpPost] // Terminada no hay data para probar (garantia)
        [Route("GetGarantiasNumOp")]
        public IActionResult GetGarantiasNumOp([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getGarantiasNumOp(data.NroOperacion));
        }


        [HttpPost] // Terminada no hay data para probar (inmueble)
        [Route("GetInmuebleByNroOp")]
        public IActionResult GetInmuebleByNroOp([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getInmuebleNoOp(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar
        [Route("GetSegundaHipotecaByNroOp")]
        public IActionResult GetHipoByNoOp([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.GetHipoByNoOp(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar
        [Route("GetCancelacionHipoteca")]
        public IActionResult GetCancelacionHipoteca([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getCancelacionHipo(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar
        [Route("GetCompraDeuda")]
        public IActionResult GetCompraDeuda([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getCompraDeuda(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar
        [Route("GetVehiculo")]
        public IActionResult GetVehiculo([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getVehiculo(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar
        [Route("GetCancelacionhipotecaVehiculo")]
        public IActionResult GetCancelacionhipotecaVehiculo([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getCancelahipoVehiculo(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar
        [Route("GetMaquinariaAgricola")]
        public IActionResult GetMaquinariaAgricola([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getMaquinaAgri(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar
        [Route("GetGarantiaWarrant")]
        public IActionResult GetGarantiaWarrant([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getGarantiaWarrant(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar
        [Route("GetFianza")]
        public IActionResult GetFianza([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getFianza(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar
        [Route("GetPrendaria")]
        public IActionResult GetPrendaria([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getPrendaria(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar
        [Route("GetGarantiaAutiLiquiDPF")]
        public IActionResult GetGarantiaAutiLiquiDPF([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getGarantiaAutiLiquiDPF(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar
        [Route("GetDPFAnotacionCuenta")]
        public IActionResult GetDPFAnotacionCuenta([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getDPFAnotacionCuenta(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar
        [Route("GetFondoGarantia")]
        public IActionResult GetFondoGarantia([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getFondoGarantia(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar
        [Route("GetFOGACP")]
        public IActionResult GetFOGACP([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getFOGACP(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar
        [Route("GetCustodiabienesInmueble")]
        public IActionResult GetCustodiabienesInmueble([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getCustodiabienesInmueble(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar
        [Route("GetActivosNoSujetos")]
        public IActionResult GetActivosNoSujetos([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getActivosNoSujetos(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar
        [Route("GetProductoAlmacenado")]
        public IActionResult GetProductoAlmacenado([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getProductoAlmacenado(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar
        [Route("GetSemoviente")]
        public IActionResult GetSemoviente([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getSemoviente(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar
        [Route("GetPatentePropiedadIntelec")]
        public IActionResult GetPatentePropiedadIntelec([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getPatentePropiedadIntelec(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar
        [Route("GetGarantiaDereAutor")]
        public IActionResult GetGarantiaDereAutor([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getGarantiaDereAutor(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar
        [Route("GetCompromiVentaFuturo")]
        public IActionResult GetCompromiVentaFuturo([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getCompromiVentaFuturo(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar 
        [Route("GetAsignados")]
        public IActionResult GetAsignados([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getAsignados(data.NroOperacion));
        }


        //Base stage 192.168.200.254


        [HttpPost] // Terminada 
        [Route("Getgeneral_prmpr")]
        public IActionResult Getgeneral_prmpr([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getgeneral_prmpr(data.NroOperacion));
        }

        [HttpPost] // Terminada 
        [Route("Getgbage")]
        public IActionResult Getgbage([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getgbage(data.NroOperacion));
        }

        [HttpPost] // Terminada 
        [Route("GetTempCartera")]
        public IActionResult GetTempCartera([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getTempCartera(data.NroOperacion));
        }

        [HttpPost] // Terminada 
        [Route("Getbagecage")]
        public IActionResult Getbagecage([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getbagecage(data.NroOperacion));
        }

        [HttpPost] // Terminada 
        [Route("Getprmprnpre")]
        public IActionResult Getprmprnpre([FromBody] REQUEST_NRO_OPERACION data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getprmprnpre(data.NroOperacion));
        }


        //APIS Adolfo




    }
}

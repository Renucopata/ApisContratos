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
        public IActionResult updateEstadoCon([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.updateEstadoContratos(data.NroOperacion));
        }

        [HttpPost] // Terminada y probada
        [Route("GetContratosByNumOp")]
        public IActionResult GetContratosByNumOp([FromBody] REQUEST_NroOperacion data)
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
        public IActionResult GetGarantiasNumOp([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getGarantiasNumOp(data.NroOperacion));
        }


        [HttpPost] // Terminada no hay data para probar (inmueble)
        [Route("GetInmuebleByNroOp")]
        public IActionResult GetInmuebleByNroOp([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getInmuebleNoOp(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetSegundaHipotecaByNroOp")]
        public IActionResult GetHipoByNoOp([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.GetHipoByNoOp(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetCancelacionHipoteca")]
        public IActionResult GetCancelacionHipoteca([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getCancelacionHipo(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetCompraDeuda")]
        public IActionResult GetCompraDeuda([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getCompraDeuda(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetVehiculo")]
        public IActionResult GetVehiculo([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getVehiculo(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetCancelacionhipotecaVehiculo")]
        public IActionResult GetCancelacionhipotecaVehiculo([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getCancelahipoVehiculo(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetMaquinariaAgricola")]
        public IActionResult GetMaquinariaAgricola([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getMaquinaAgri(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetGarantiaWarrant")]
        public IActionResult GetGarantiaWarrant([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getGarantiaWarrant(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetFianza")]
        public IActionResult GetFianza([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getFianza(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetPrendaria")]
        public IActionResult GetPrendaria([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getPrendaria(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetGarantiaAutiLiquiDPF")]
        public IActionResult GetGarantiaAutiLiquiDPF([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getGarantiaAutiLiquiDPF(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetDPFAnotacionCuenta")]
        public IActionResult GetDPFAnotacionCuenta([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getDPFAnotacionCuenta(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetFondoGarantia")]
        public IActionResult GetFondoGarantia([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getFondoGarantia(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetFOGACP")]
        public IActionResult GetFOGACP([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getFOGACP(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetCustodiabienesInmueble")]
        public IActionResult GetCustodiabienesInmueble([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getCustodiabienesInmueble(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetActivosNoSujetos")]
        public IActionResult GetActivosNoSujetos([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getActivosNoSujetos(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetProductoAlmacenado")]
        public IActionResult GetProductoAlmacenado([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getProductoAlmacenado(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetSemoviente")]
        public IActionResult GetSemoviente([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getSemoviente(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetPatentePropiedadIntelec")]
        public IActionResult GetPatentePropiedadIntelec([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getPatentePropiedadIntelec(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetGarantiaDereAutor")]
        public IActionResult GetGarantiaDereAutor([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getGarantiaDereAutor(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetCompromiVentaFuturo")]
        public IActionResult GetCompromiVentaFuturo([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getCompromiVentaFuturo(data.NroOperacion));
        }

        [HttpPost] // Terminada no hay data para probar (segunda_hipoteca)
        [Route("GetAsignados")]
        public IActionResult GetAsignados([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getAsignados(data.NroOperacion));
        }


    }
}

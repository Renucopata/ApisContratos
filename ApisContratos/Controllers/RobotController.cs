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

        [HttpGet] //Terminada
        [Route("GetAllProcRWeb")]
        public IActionResult getProcRweb()
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getProcsRWeb());
        }

        [HttpPost] //Terminada
        [Route("GetAllProcRWeb")]
        public IActionResult getProcRweb([FromBody] REQUEST_ID data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.deleteRWeb(data.id));
        }

        [HttpPost] // Probada y funcionando
        [Route("UpdateEstadoContratos")]
        public IActionResult updateEstadoCon([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.updateEstadoContratos(data.NroOperacion));
        }

        [HttpPost] // Terminada
        [Route("GetContratosByNumOp")]
        public IActionResult GetContratosByNumOp([FromBody] REQUEST_NroOperacion data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getContratosNumOp(data.NroOperacion));
        }

        [HttpPost] // Terminada
        [Route("GetRepreLegalByJefeAg")]
        public IActionResult GetRepreByJefeAg([FromBody] REQUEST_JEFE_AGENCIA data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getRepreJefeAg(data.jefeAgencia));
        }


    }
}

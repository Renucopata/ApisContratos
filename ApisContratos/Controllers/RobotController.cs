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

        [HttpGet] // Probada y funcionando
        [Route("GetAllProcRWeb")]
        public IActionResult getProcRweb()
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.getProcsRWeb());
        }

        [HttpPost] // Probada y funcionando
        [Route("GetAllProcRWeb")]
        public IActionResult getProcRweb([FromBody] REQUEST_ID data)
        {

            Procedures pro = new Procedures();
            ModelState.Clear();
            return Ok(pro.deleteRWeb(data.id));
        }


    }
}

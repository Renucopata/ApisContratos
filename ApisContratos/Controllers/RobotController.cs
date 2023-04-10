using ApisContratos.Handlers;
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


    }
}

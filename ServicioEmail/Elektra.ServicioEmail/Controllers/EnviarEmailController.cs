using Elektra.ServicioEmail.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Elektra.ServicioEmail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnviarEmailController : ControllerBase
    {
        private readonly IEmail _emailServicio;
        public EnviarEmailController(IEmail emailServicio)
        {
            _emailServicio = emailServicio;
        }

        //[HttpPost]
        [Route("EnviarEmail/send-email")]
        public async Task<IActionResult> EnviarEmailAsync([System.Web.Http.FromUri]string email, string subject, string message)
        {
            await _emailServicio.SendEmail(email, subject, message);
            return Ok();
        }


    }
}
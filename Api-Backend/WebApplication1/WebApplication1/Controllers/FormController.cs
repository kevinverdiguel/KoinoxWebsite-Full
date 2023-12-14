using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    [ApiController]
    [Route("api/[controller")]
    public class FormController : Controller
    {
        private IConfiguration Configuration;

        public FormController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }


        [HttpPost]
        public async Task<IActionResult> AddForms([FromBody] Form form)
        {
            string host = this.Configuration.GetValue<string>("Smtp: server");
            int port = this.Configuration.GetValue<int>("Smtp: Port");
            string fromAddress = this.Configuration.GetValue<string>("Smtp: FromAddress");
            string userName = this.Configuration.GetValue<string>("Smtp: Username");
            string password = this.Configuration.GetValue<string>("Smtp: Password");

            using (MailMessage mm = new MailMessage(fromAddress, "admin@koinox.com"))
            {
                mm.Subject = "Nuevo contacto";

            }

        }
    }
}

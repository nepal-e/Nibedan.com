using Microsoft.AspNetCore.Mvc;

namespace Nidedan.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FormInfoController : Controller
    {
        [HttpGet(Name = "GetFormList")]
        public string[] GetFormList()
        {
            return new string[] { "Passport","Birth Certificate","Malpot","Lok Sewa"};
        }
    }
}

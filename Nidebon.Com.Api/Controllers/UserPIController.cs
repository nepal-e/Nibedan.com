using Microsoft.AspNetCore.Mvc;

namespace Nidebon.Com.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPIController : Controller
    {
        [HttpGet]
        public IEnumerable<string> GetUserPI()
        {
            return new string[] { "Angat", "23", "Surkhet", "113526182" };
        }

        [HttpGet("{id}")]
        public string GetUserPIByID(int id)
        {
            return "Angat";
        }
    }
}

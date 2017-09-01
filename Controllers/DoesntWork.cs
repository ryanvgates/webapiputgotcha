using Microsoft.AspNetCore.Mvc;

namespace webapiputgotcha.Controllers
{
    [Route("api/[controller]")]
    public class DoesntWorkController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Doesn't work get method.";
        }

        [HttpPut]
        public string Put([FromRoute] int companyId, object company)
        {
            return companyId + " was the parameter.";
        }
    }
}
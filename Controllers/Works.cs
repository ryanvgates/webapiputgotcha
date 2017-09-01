using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace webapiputgotcha.Controllers
{
    [Route("api/[controller]")]
    public class WorksController : Controller
    {
        [HttpPut]
        public string Put([FromRoute] int id, object company)
        {
            return id + " was the parameter.";
        }
    }
}
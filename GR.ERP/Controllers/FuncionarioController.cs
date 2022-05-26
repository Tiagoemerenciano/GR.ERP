using GR.ERP.Api.Requests.Funcionario;
using Microsoft.AspNetCore.Mvc;

namespace GR.ERP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        // GET api/funcionario
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/funcionario/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/funcionario
        [HttpPost]
        public void Post([FromBody] CadastrarFuncionarioRequest funcionario)
        {
            
        }

        // PUT api/funcionario/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/funcionario/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

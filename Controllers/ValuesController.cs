using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac.Extras.DynamicProxy;
using Microsoft.AspNetCore.Mvc;

namespace TryAutoFac.Interceptor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // [Intercept(typeof(AuthorizationInterceptor))]
    public class ValuesController : ControllerBase
    {
        private readonly IFooService _fooService;
        public ValuesController(IFooService fooService)
        {
            _fooService = fooService;
        }
        // GET api/values
        [HttpGet]
        public virtual ActionResult<IEnumerable<string>> Get()
        {
            // _fooService.Say("Hi");

            return new string[] { "value1", "value2" };
        }

        // // GET api/values/5
        // [HttpGet("{id}")]
        // public ActionResult<string> Get(int id)
        // {
        //     return "value";
        // }

        // // POST api/values
        // [HttpPost]
        // public void Post([FromBody] string value)
        // {
        // }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}

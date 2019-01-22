using System;
using System.Collections;
using System.Web.Http;

namespace WebApi.Controller
{
    public class VariablesController : ApiController
    {
        [HttpGet]
        [Route("environment-variables")]
        public IDictionary EnvironmentVariables()
        {
            IDictionary environmentVariables = Environment.GetEnvironmentVariables();
            return environmentVariables;
        }

        [HttpGet]
        [Route("environment-variable/{key}")]
        public IHttpActionResult EnvironmentVariableByKey(string key)
        {
            string value = Environment.GetEnvironmentVariable(key);

            if (string.IsNullOrEmpty(value))
            {
                return BadRequest("Inroccect key");
            }
            
            return Ok(value);
        }
    }
}

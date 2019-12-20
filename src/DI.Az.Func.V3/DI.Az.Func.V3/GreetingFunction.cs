using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using DI.Az.Func.V3.App.Services;

namespace DI.Az.Func.V3
{
    public class GreetingFunction
    {
        private IGreetingService greetingService;

        public GreetingFunction(IGreetingService greetingService)
        {
            this.greetingService = greetingService;
        }
        [FunctionName("Greeting")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            return name != null
                ? (ActionResult)new OkObjectResult(greetingService.Greet(name))
                : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
        }
    }
}

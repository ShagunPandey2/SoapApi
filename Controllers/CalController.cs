using Calculator.Model;
using Microsoft.AspNetCore.Mvc;
using ServiceReference1;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("CalController")]
    public class CalController : Controller
    {
        [HttpGet("Add")]
        public async Task<double> addAsync(double a,double b)
        {
            ICalService calService=new CalServiceClient(CalServiceClient.EndpointConfiguration.BasicHttpBinding_ICalService);
            return await calService.addAsync(a,b);
        }

        [HttpGet("Sub")]
        public async Task<double> subAsync(double a, double b)
        {
            ICalService calService = new CalServiceClient(CalServiceClient.EndpointConfiguration.BasicHttpBinding_ICalService);
            return await calService.subAsync(a, b);
        }

        [HttpGet("Div")]
        public async Task<double> divAsync(double a, double b)
        {
            ICalService calService = new CalServiceClient(CalServiceClient.EndpointConfiguration.BasicHttpBinding_ICalService);
            return await calService.divAsync(a, b);
        }

        [HttpGet("Mul")]
        public async Task<double> mulAsync(double a, double b)
        {
            ICalService calService = new CalServiceClient(CalServiceClient.EndpointConfiguration.BasicHttpBinding_ICalService);
            return await calService.mulAsync(a, b);
        }
    }
}

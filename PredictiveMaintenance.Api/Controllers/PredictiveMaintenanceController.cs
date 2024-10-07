using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PredictiveMaintenance;
using static PredictiveMaintenance.PredictiveMaintenanceModel;

namespace PredictiveMaintenance.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PredictiveMaintenanceController : ControllerBase
    {


        [HttpPost]
        [Route("/Maintenance/Predict")]
        public async Task<IActionResult> Predict([FromBody] ModelInput input)
        {
            var response = PredictiveMaintenanceModel.Predict(input);
            return  Ok(response);
        }
    }
}

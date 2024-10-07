using Microsoft.AspNetCore.Mvc;
using PredictiveMaintenance.Api.Adapter;
using PredictiveMaintenance.Core;
using static PredictiveMaintenance.Core.PredictiveMaintenanceModel;

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
            var machineInfo = ModelOutputAdapter.OutputAdapter(response, input);
            return  Ok(machineInfo);
        }
    }
}

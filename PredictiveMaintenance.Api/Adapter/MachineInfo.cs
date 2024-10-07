using Microsoft.ML.Data;

namespace PredictiveMaintenance.Api.Adapter
{
    public class MachineInfo
    {
        public string ProductId { get; set; }
        public string Type { get; set; }
        public float AirTemperature { get; set; }
        public float ProcessTemperature { get; set; }
        public float RotationalSpeed { get; set; }
        public float Torque { get; set; }
        public float ToolWear { get; set; }
        public string PredictedLabel { get; set; }
        public float[] Score { get; set; }
    }
}

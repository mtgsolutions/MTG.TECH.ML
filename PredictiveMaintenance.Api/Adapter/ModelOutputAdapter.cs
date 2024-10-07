using static PredictiveMaintenance.Core.PredictiveMaintenanceModel;


namespace PredictiveMaintenance.Api.Adapter;

public static class ModelOutputAdapter
{
    public static MachineInfo OutputAdapter(ModelOutput modelOutput, ModelInput modelInput)
    {
        return new MachineInfo
        {
            ProductId = modelInput.Product_ID,
            Type = modelInput.Type,
            AirTemperature = modelOutput.Air_temperature,
            ProcessTemperature = modelOutput.Process_temperature,
            RotationalSpeed = modelOutput.Rotational_speed,
            Torque = modelOutput.Torque,
            ToolWear = modelOutput.Tool_wear,
            PredictedLabel = modelOutput.PredictedLabel==0 ? "Normal" : "Failure",
            Score = CalculatePercentualScore(modelOutput.Score)
        };
    }

    private static float[] CalculatePercentualScore(float[] value)
    {
        for(int i = 0; i < value.Length; i++)
        {
            value[i] = value[i] * 100;
        }
        return value;
    }


}


namespace Device.API.Repositories
{
    public interface ISensorRepository
    {
        string GetSensorName(int DeviceId);
        string GetSensorCapabilities(int DeviceId);
    }
}
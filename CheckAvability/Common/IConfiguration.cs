namespace CheckAvability.Common
{
    public interface IConfiguration
    {
        string GetAvailabilityUrl();
        string GetStoreUrl();
        string GetBaseUrl();
        string GetLoginUrl();
        string GetLoginBaseUrl();
        string GetLoginPostBaseUrl();

        string GetLoginPostUrl();
    }
}
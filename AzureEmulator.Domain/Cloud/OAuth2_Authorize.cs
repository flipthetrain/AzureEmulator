namespace AzureEmulator.Domain.Cloud
{
    public record OAuth2_Authorize
    {
        //https://login.microsoftonline.com.localhost:5000/common/oauth2/authorize?response_type=code&client_id=04b07795-8ddb-461a-bbee-02f9e1bf7b46&redirect_uri=http://localhost:8400&state=4umctq8j9gxaqv21pole&resource=https://management.core.windows.net.localhost:5000/&prompt=select_account
        public string response_type { get; set; }
        public string client_id { get; set; }
        public string redirect_uri { get; set; }
        public string state { get; set; }
        public string resource { get; set; }
        public string prompt { get; set; }
    }
}

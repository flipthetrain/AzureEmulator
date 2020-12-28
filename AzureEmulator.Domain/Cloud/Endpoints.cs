namespace AzureEmulator.Domain.Cloud
{
    public record Endpoints
    {
        public string activeDirectory { get; set; }
        public string activeDirectoryDataLakeResourceId { get; set; }
        public string activeDirectoryGraphResourceId { get; set; }
        public string activeDirectoryResourceId { get; set; }
        public string appInsightsResourceId { get; set; }
        public string appInsightsTelemetryChannelResourceId { get; set; }
        public string batchResourceId { get; set; }
        public string gallery { get; set; }
        public string logAnalyticsResourceId { get; set; }
        public string management { get; set; }
        public string mediaResourceId { get; set; }
        public string microsoftGraphResourceId { get; set; }
        public string ossrdbmsResourceId { get; set; }
        public string resourceManager { get; set; }
        public string sqlManagement { get; set; }
        public string vmImageAliasDoc { get; set; }
    }
}

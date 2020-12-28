namespace AzureEmulator.Domain.Cloud
{
    public record Suffixes
    {
        public string acrLoginServerEndpoint { get; set; }
        public string azureDatalakeAnalyticsCatalogAndJobEndpoint { get; set; }
        public string azureDatalakeStoreFileSystemEndpoint { get; set; }
        public string keyvaultDns { get; set; }
        public string mariadbServerEndpoint { get; set; }
        public string mysqlServerEndpoint { get; set; }
        public string postgresqlServerEndpoint { get; set; }
        public string sqlServerHostname { get; set; }
        public string storageEndpoint { get; set; }
    }
}

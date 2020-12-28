namespace AzureEmulator.Domain.Cloud
{
    public record CloudEndpoints
    {
        public string galleryEndpoint { get; set; }
        public string graphEndpoint { get; set; }
        public string portalEndpoint { get; set; }
        public Authentication authentication { get; set; }
    }
}

namespace AzureEmulator.Domain.Cloud
{
    public record Example
    {
        public Endpoints endpoints { get; set; }
        public bool isActive { get; set; }
        public string name { get; set; }
        public string profile { get; set; }
        public Suffixes suffixes { get; set; }
    }
}

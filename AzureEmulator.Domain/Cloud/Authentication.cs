using System.Collections.Generic;

namespace AzureEmulator.Domain.Cloud
{
    public record Authentication
    {
        public string loginEndpoint { get; set; }
        public IList<string> audiences { get; set; }
    }
}

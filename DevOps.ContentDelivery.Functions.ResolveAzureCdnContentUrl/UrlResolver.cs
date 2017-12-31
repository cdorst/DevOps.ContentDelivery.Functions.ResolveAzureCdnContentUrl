using DevOps.ContentDelivery.Structures.AzureBlob;
using System;

namespace DevOps.ContentDelivery.Functions.ResolveAzureCdnContentUrl
{
    public static class UrlResolver
    {
        public static Uri Url(string endpointName, Blob blob)
            => new Uri($"https://{endpointName}.azureedge.net/{blob.Container}/{blob.Name}");
    }
}

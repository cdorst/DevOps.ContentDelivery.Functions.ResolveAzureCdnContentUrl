using System;

namespace DevOps.ContentDelivery.Functions.ResolveAzureCdnContentUrl
{
    public static class UrlResolver
    {
        public static Uri Url(string endpointName, string path)
            => new Uri($"https://{endpointName}.azureedge.net/{path}");
    }
}

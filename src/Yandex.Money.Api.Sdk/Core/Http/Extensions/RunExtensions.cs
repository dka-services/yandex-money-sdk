using System;
using System.IO;
using System.Net.Mime;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Yandex.Money.Api.Sdk.Core.Http
{
    public static class RunExtensions
    {
        private static readonly JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();

        public static async Task<string> AsStringAsync(this IRequest request)
        {
            var response = await request.RunAsync();

            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<byte[]> AsByteArrayAsync(this IRequest request)
        {
            var response = await request.RunAsync();

            return await response.Content.ReadAsByteArrayAsync();
        }

        public static async Task<Stream> AsStreamAsync(this IRequest request)
        {
            var response = await request.RunAsync();

            return await response.Content.ReadAsStreamAsync();
        }

        public static async Task<T> AsAsync<T>(this IRequest request)
        {
            var response = await request.RunAsync();
            if (!response.IsSuccessStatusCode)
                return default(T);

            return parse(await response.Content.ReadAsStringAsync());

            T parse(string raw)
            {
                var mediaType = response.Content.Headers.ContentType.MediaType;

                switch (mediaType)
                {
                    case MediaTypeNames.Application.Json:
                        return JsonConvert.DeserializeObject<T>(raw, jsonSerializerSettings);
                    default:
                        throw new NotSupportedException($"Media type '{mediaType}' is not supported");
                }
            }
        }
    }
}
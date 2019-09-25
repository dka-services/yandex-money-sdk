using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Yandex.Money.Api.Sdk.Core.Http
{
    public interface IResponse
    {
        HttpStatusCode StatusCode { get; }

        string ReasonPhrase { get; }

        bool IsSuccessStatusCode { get; }

        HttpResponseHeaders Headers { get; }

        HttpContent Content { get; }
    }
}
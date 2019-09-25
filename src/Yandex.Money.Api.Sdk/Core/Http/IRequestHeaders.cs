using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Yandex.Money.Api.Sdk.Core.Http
{
    public partial interface IRequest
    {
        IRequest Header(string name, string value);

        IRequest Header(string name, IEnumerable<string> values);

        IRequest Authorization(AuthenticationHeaderValue value);
    }
}
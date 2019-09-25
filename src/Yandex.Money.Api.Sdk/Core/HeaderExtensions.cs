
using Yandex.Money.Api.Sdk.Core.Http;

namespace Yandex.Money.Api.Sdk.Core
{
    public static class HeaderExtensions
    {
        public static IRequest IdempotenceKey(this IRequest request, string idempotenceKey)
        {
            return request.Header("Idempotence-Key", idempotenceKey);
        }
    }
}
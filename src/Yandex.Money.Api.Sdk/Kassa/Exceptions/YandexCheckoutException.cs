using System;
using System.Net;
using Yandex.Money.Api.Sdk.Kassa.Models;

namespace Yandex.Money.Api.Sdk.Kassa.Exceptions
{
    /// <summary>
    ///     Represents Yandex.Checkout API error responce
    /// </summary>
    [Serializable]
    public class YandexCheckoutException : Exception
    {
        public YandexCheckoutException(HttpStatusCode statusCode, Error error) : base(error.Description)
        {
            StatusCode = statusCode;
            Error = error;
        }

        /// <summary>
        ///     Status code returned from server
        /// </summary>
        public HttpStatusCode StatusCode { get; }

        /// <summary>
        ///     Error object returned from server
        /// </summary>
        public Error Error { get; }
    }
}
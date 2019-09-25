namespace Yandex.Money.Api.Sdk.Kassa
{
    /// <summary>
    ///     Yandex Configuration
    /// </summary>
    public class Configuration
    {
        /// <summary>
        ///     API Version
        /// </summary>
        private static string Version => "v3";

        /// <summary>
        ///     Api Yandex
        /// </summary>
        internal string ApiUrl => $"https://payment.yandex.net/api/{Version}/";

        /// <summary>
        ///     Shop ID
        /// </summary>
        public string ShopId { get; set; }

        /// <summary>
        ///     Shop Secret
        /// </summary>
        public string ShopSecret { get; set; }
    }
}
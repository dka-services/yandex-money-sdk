using System.Runtime.Serialization;

namespace Yandex.Money.Api.Sdk.Kassa.Models.Payments
{
    /// <summary>
    ///     Получатель платежа.
    /// </summary>
    [DataContract]
    public class Recipient
    {
        /// <summary>
        ///     Идентификатор магазина в Яндекс.Кассе.
        /// </summary>
        [DataMember(Name = "account_id", IsRequired = true)]
        public string AccountId { get; set; }

        /// <summary>
        ///     Идентификатор субаккаунта. Используется для разделения потоков платежей в рамках одного аккаунта.
        /// </summary>
        [DataMember(Name = "gateway_id", IsRequired = true)]
        public string GatewayId { get; set; }
    }
}
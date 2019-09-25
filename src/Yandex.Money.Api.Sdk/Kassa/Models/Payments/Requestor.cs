using System.Runtime.Serialization;
using Yandex.Money.Api.Sdk.Kassa.Enums.Payments;

namespace Yandex.Money.Api.Sdk.Kassa.Models.Payments
{
    /// <summary>
    ///     Инициатор платежа или возврата. Инициатором может быть магазин, подключенный к Яндекс.Кассе,
    ///     (merchant) или приложение, которому владелец магазина разрешил  совершать операции от своего имени (third_party_client).
    /// </summary>
    [DataContract]
    public class Requestor
    {
        /// <summary>
        ///     Тип инициатора.
        /// </summary>
        [DataMember(Name = "type", IsRequired = true)]
        public RequestorType Type { get; set; }

        /// <summary>
        ///     Идентификатор магазина в Яндекс.Кассе.
        /// </summary>
        [DataMember(Name = "account_id", IsRequired = true)]
        public string AccountId { get; set; }

        /// <summary>
        ///     Идентификатор приложения.
        /// </summary>
        [DataMember(Name = "client_id", IsRequired = true)]
        public string ClientId { get; set; }

        /// <summary>
        ///     Название приложения.
        /// </summary>
        [DataMember(Name = "client_name", IsRequired = true)]
        public string ClientName { get; set; }
    }
}
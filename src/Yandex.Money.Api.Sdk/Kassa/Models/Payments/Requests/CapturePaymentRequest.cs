using System.Runtime.Serialization;

namespace Yandex.Money.Api.Sdk.Kassa.Models.Payments.Requests
{
    /// <summary>
    ///     Подтверждение платежа
    ///     <see href="https://kassa.yandex.ru/developers/api?lang=php#capture_payment" />
    /// </summary>
    [DataContract]
    public class CapturePaymentRequest
    {
        /// <summary>
        ///     Сумма платежа. Иногда партнеры Яндекс.Кассы берут с пользователя дополнительную комиссию, которая не входит в эту сумму.
        /// </summary>
        [DataMember(Name = "amount", IsRequired = false)]
        public Amount Amount { get; set; }

        /// <summary>
        ///     Данные для формирования чека в онлайн-кассе (для соблюдения 54-ФЗ ).
        /// </summary>
        [DataMember(Name = "receipt", IsRequired = false)]
        public Receipt Receipt { get; set; }

        /// <summary>
        ///     Объект с данными для продажи авиабилетов . Используется только для платежей банковской картой.
        /// </summary>
        [DataMember(Name = "airline", IsRequired = false)]
        public Airline Airline { get; set; }
    }
}
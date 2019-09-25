using System.Runtime.Serialization;

namespace Yandex.Money.Api.Sdk.Kassa.Models.Payments
{
    /// <summary>
    ///     Сумма, которая вернулась пользователю. Присутствует, если у этого платежа есть успешные возвраты.
    /// </summary>
    [DataContract]
    public class RefundedAmount
    {
        /// <summary>
        ///     Сумма в выбранной валюте. Выражается в виде строки и пишется через точку, например 10.00.
        ///     Количество знаков после точки зависит от выбранной валюты.
        /// </summary>
        [DataMember(Name = "value", IsRequired = true)]
        public string Value { get; set; }

        /// <summary>
        ///     Код валюты в формате ISO-4217. Должен соответствовать валюте субаккаунта (recipient.gateway_id),
        ///     если вы разделяете потоки платежей, и валюте аккаунта (shopId в личном кабинете), если не разделяете.
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true)]
        public string Currency { get; set; }
    }
}
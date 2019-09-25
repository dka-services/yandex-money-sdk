using System.Runtime.Serialization;

namespace Yandex.Money.Api.Sdk.Kassa.Models.Payments
{
    /// <summary>
    ///     Комментарий к статусу canceled: кто отменил платеж и по какой причине. Подробнее про неуспешные платежи
    /// </summary>
    [DataContract]
    public class CancellationDetails
    {
        /// <summary>
        ///     Участник процесса платежа, который принял решение об отмене транзакции.
        ///     Может принимать значения yandex_checkout, payment_network и merchant. Подробнее про инициаторов отмены платежа
        /// </summary>
        [DataMember(Name = "party", IsRequired = true)]
        public string Party { get; set; }

        /// <summary>
        ///     Причина отмены платежа. Перечень и описание возможных значений
        /// </summary>
        [DataMember(Name = "reason", IsRequired = true)]
        public string Reason { get; set; }
    }
}
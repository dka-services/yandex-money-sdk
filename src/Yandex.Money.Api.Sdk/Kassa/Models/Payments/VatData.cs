using System.Runtime.Serialization;
using Yandex.Money.Api.Sdk.Kassa.Enums.Payments;

namespace Yandex.Money.Api.Sdk.Kassa.Models.Payments
{
    /// <summary>
    ///     Данные о налоге на добавленную стоимость (НДС).
    ///     Платеж может облагаться и не облагаться НДС.
    ///     Товары могут облагаться по одной ставке НДС или по разным.
    /// </summary>
    [DataContract]
    public class VatData
    {
        /// <summary>
        ///     Код способа расчета НДС.
        /// </summary>
        [DataMember(Name = "type", IsRequired = true)]
        public VatDataType Type { get; set; }

        /// <summary>
        ///     Сумма НДС.
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true)]
        public VatDataAmount Amount { get; set; }

        /// <summary>
        ///     Налоговая ставка (в процентах). Возможные значения: 7, 10, 18 и 20.
        /// </summary>
        [DataMember(Name = "rate", IsRequired = true)]
        public string Rate { get; set; }
    }
}
using System.Runtime.Serialization;

namespace Yandex.Money.Api.Sdk.Kassa.Models.Payments
{
    /// <summary>
    ///     Данные банковской карты.
    /// </summary>
    [DataContract]
    public class Card
    {
        /// <summary>
        ///     Первые 6 цифр номера карты (BIN).
        /// </summary>
        [DataMember(Name = "first6", IsRequired = true)]
        public string First6 { get; set; }

        /// <summary>
        ///     Последние 4 цифры номера карты.
        /// </summary>
        [DataMember(Name = "last4", IsRequired = true)]
        public string Last4 { get; set; }

        /// <summary>
        ///     Срок действия, год, YYYY.
        /// </summary>
        [DataMember(Name = "expiry_year", IsRequired = true)]
        public string ExpiryYear { get; set; }

        /// <summary>
        ///     Срок действия, месяц, MM.
        /// </summary>
        [DataMember(Name = "expiry_month", IsRequired = true)]
        public string ExpiryMonth { get; set; }

        /// <summary>
        ///     Тип банковской карты. Возможные значения:
        ///     MasterCard (для карт Mastercard и Maestro),
        ///     Visa (для карт Visa и Visa Electron),
        ///     Mir, UnionPay, JCB, AmericanExpress, DinersClub и Unknown.
        /// </summary>
        [DataMember(Name = "card_type", IsRequired = true)]
        public string CardType { get; set; }

        /// <summary>
        ///     Код страны, в которой выпущена карта. Передается в формате ISO-3166 alpha-2. Пример: RU.
        /// </summary>
        [DataMember(Name = "issuer_country", IsRequired = false)]
        public string IssuerCountry { get; set; }

        /// <summary>
        ///     Наименование банка, выпустившего карту.
        /// </summary>
        [DataMember(Name = "issuer_name", IsRequired = false)]
        public string IssuerName { get; set; }

        /// <summary>
        ///     Источник данных банковской карты. Возможное значение: google_pay.
        ///     Присутствует, если пользователь при оплате выбрал карту, сохраненную в Google Pay.
        /// </summary>
        [DataMember(Name = "source", IsRequired = false)]
        public string Source { get; set; }
    }
}
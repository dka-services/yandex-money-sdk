using System.Runtime.Serialization;
using Yandex.Money.Api.Sdk.Kassa.Enums.Payments;

namespace Yandex.Money.Api.Sdk.Kassa.Models.Payments
{
    [DataContract]
    public class ReceiptItem
    {
        /// <summary>
        ///     Название товара (не более 128 символов).
        /// </summary>
        [DataMember(Name = "description", IsRequired = true)]
        public string Description { get; set; }

        /// <summary>
        ///     Количество товара. Максимально возможное значение зависит от модели вашей онлайн-кассы.
        /// </summary>
        [DataMember(Name = "quantity", IsRequired = true)]
        public string Quantity { get; set; }

        /// <summary>
        ///     Цена товара.
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true)]
        public Amount Amount { get; set; }

        /// <summary>
        ///     Ставка НДС. Возможные значения — числа от 1 до 6. Подробнее про коды ставок НДС
        /// </summary>
        [DataMember(Name = "vat_code", IsRequired = true)]
        public VatCode VatCode { get; set; }

        /// <summary>
        ///     Признак предмета расчета. Перечень возможных значений
        /// </summary>
        [DataMember(Name = "payment_subject", IsRequired = false)]
        public string PaymentSubject { get; set; }

        /// <summary>
        ///     Признак способа расчета. Перечень возможных значений
        /// </summary>
        [DataMember(Name = "payment_mode", IsRequired = false)]
        public string PaymentMode { get; set; }

        /// <summary>
        ///     Код товара — уникальный номер, который присваивается экземпляру товара при маркировке.
        ///     Формат: число в шестнадцатеричном представлении с пробелами. Максимальная длина — 32 байта.
        ///     Пример: 00 00 00 01 00 21 FA 41 00 23 05 41 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 12 00 AB 00.
        ///     Обязательный параметр, если товар нужно маркировать.
        ///     Онлайн-кассы, которые поддерживают этот параметр: Orange Data, АТОЛ Онлайн.
        /// </summary>
        [DataMember(Name = "product_code", IsRequired = false)]
        public string ProductCode { get; set; }

        /// <summary>
        ///     Код страны происхождения товара по общероссийскому классификатору стран мира (OК (MК (ИСО 3166) 004-97) 025-2001). Пример: RU.
        /// </summary>
        [DataMember(Name = "country_of_origin_code", IsRequired = false)]
        public string CountryOfOriginCode { get; set; }

        /// <summary>
        ///     Номер таможенной декларации (от 1 до 32 символов).
        ///     Онлайн-кассы, которые поддерживают этот параметр: Orange Data.
        /// </summary>
        [DataMember(Name = "customs_declaration_number", IsRequired = false)]
        public string CustomsDeclarationNumber { get; set; }

        /// <summary>
        ///     Сумма акциза товара с учетом копеек. Десятичное число с точностью до 2 символов после точки.
        ///     Онлайн-кассы, которые поддерживают этот параметр: Orange Data.
        /// </summary>
        [DataMember(Name = "excise", IsRequired = false)]
        public string Excise { get; set; }
    }
}
using System.Collections.Generic;
using System.Runtime.Serialization;
using Yandex.Money.Api.Sdk.Kassa.Enums.Payments;

namespace Yandex.Money.Api.Sdk.Kassa.Models.Payments
{
    /// <summary>
    ///     Данные для формирования чека в онлайн-кассе (для соблюдения 54-ФЗ ).
    /// </summary>
    [DataContract]
    public class Receipt
    {
        /// <summary>
        ///     Информация о пользователе.
        ///     Необходимо указать как минимум контактные данные: электронную почту (customer.email) или номер телефона (customer.phone).
        /// </summary>
        [DataMember(Name = "customer", IsRequired = false)]
        public Customer Customer { get; set; }

        /// <summary>
        ///     Список товаров в заказе.
        /// </summary>
        [DataMember(Name = "items", IsRequired = true)]
        public ICollection<ReceiptItem> Items { get; set; } = new List<ReceiptItem>();

        /// <summary>
        ///     Система налогообложения магазина.
        ///     Параметр необходим, только если у вас несколько систем налогообложения, в остальных случаях не передается.
        ///     Перечень возможных значений
        /// </summary>
        [DataMember(Name = "tax_system_code", IsRequired = false)]
        public TaxSystem TaxSystemCode { get; set; }

        /// <summary>
        ///     Телефон пользователя. Указывается в формате ITU-T E.164, например 79000000000.
        /// </summary>
        [DataMember(Name = "phone", IsRequired = false)]
        public string Phone { get; set; }

        /// <summary>
        ///     Электронная почта пользователя.
        /// </summary>
        [DataMember(Name = "email", IsRequired = false)]
        public string Email { get; set; }
    }
}
using System.Runtime.Serialization;

namespace Yandex.Money.Api.Sdk.Kassa.Models.Payments
{
    /// <summary>
    ///     Банковские реквизиты плательщика (юридического лица или ИП).
    /// </summary>
    [DataContract]
    public class PayerBankDetails
    {
        /// <summary>
        ///     Полное наименование организации.
        /// </summary>
        [DataMember(Name = "full_name", IsRequired = true)]
        public string FullName { get; set; }

        /// <summary>
        ///     Сокращенное наименование организации.
        /// </summary>
        [DataMember(Name = "short_name", IsRequired = true)]
        public string ShortName { get; set; }

        /// <summary>
        ///     Адрес организации.
        /// </summary>
        [DataMember(Name = "address", IsRequired = true)]
        public string Address { get; set; }

        /// <summary>
        ///     Индивидуальный налоговый номер (ИНН) организации.
        /// </summary>
        [DataMember(Name = "inn", IsRequired = true)]
        public string Inn { get; set; }

        /// <summary>
        ///     Код причины постановки на учет (КПП) организации.
        /// </summary>
        [DataMember(Name = "kpp", IsRequired = true)]
        public string Kpp { get; set; }

        /// <summary>
        ///     Наименование банка организации.
        /// </summary>
        [DataMember(Name = "bank_name", IsRequired = true)]
        public string BankName { get; set; }

        /// <summary>
        ///     Отделение банка организации.
        /// </summary>
        [DataMember(Name = "bank_branch", IsRequired = true)]
        public string BankBranch { get; set; }

        /// <summary>
        ///     Банковский идентификационный код (БИК) банка организации.
        /// </summary>
        [DataMember(Name = "bank_bik", IsRequired = true)]
        public string BankBik { get; set; }

        /// <summary>
        ///     Номер счета организации.
        /// </summary>
        [DataMember(Name = "account", IsRequired = true)]
        public string Account { get; set; }
    }
}
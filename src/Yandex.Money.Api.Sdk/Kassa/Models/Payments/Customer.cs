using System.Runtime.Serialization;

namespace Yandex.Money.Api.Sdk.Kassa.Models.Payments
{
    /// <summary>
    ///     Информация о пользователе. Необходимо указать как минимум контактные данные: электронную почту (customer.email) или номер телефона (customer.phone).
    /// </summary>
    [DataContract]
    public class Customer
    {
        /// <summary>
        ///     Для юрлица — название организации, для ИП и физического лица — ФИО.
        ///     Если у физлица отсутствует ИНН, в этом же параметре передаются паспортные данные. Не более 256 символов.
        ///     Онлайн-кассы, которые поддерживают этот параметр: Orange Data, АТОЛ Онлайн.
        /// </summary>
        [DataMember(Name = "full_name", IsRequired = false)]
        public string FullName { get; set; }

        /// <summary>
        ///     ИНН пользователя (10 или 12 цифр). Если у физического лица отсутствует ИНН, необходимо передать паспортные данные в параметре full_name.
        ///     Онлайн-кассы, которые поддерживают этот параметр: Orange Data, АТОЛ Онлайн.
        /// </summary>
        [DataMember(Name = "inn", IsRequired = false)]
        public string Inn { get; set; }

        /// <summary>
        ///     Электронная почта пользователя.
        /// </summary>
        [DataMember(Name = "email", IsRequired = false)]
        public string Email { get; set; }

        /// <summary>
        ///     Телефон пользователя. Указывается в формате ITU-T E.164, например 79000000000.
        /// </summary>
        [DataMember(Name = "phone", IsRequired = false)]
        public string Phone { get; set; }
    }
}
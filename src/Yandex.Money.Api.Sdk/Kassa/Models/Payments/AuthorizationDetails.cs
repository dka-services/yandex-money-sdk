using System.Runtime.Serialization;

namespace Yandex.Money.Api.Sdk.Kassa.Models.Payments
{
    /// <summary>
    ///     Данные об авторизации платежа.
    /// </summary>
    [DataContract]
    public class AuthorizationDetails
    {
        /// <summary>
        ///     Retrieval Reference Number — уникальный идентификатор транзакции в системе эмитента. Используется при оплате банковской картой.
        /// </summary>
        [DataMember(Name = "rrn", IsRequired = false)]
        public string Rrn { get; set; }

        /// <summary>
        ///     Код авторизации банковской карты. Выдается эмитентом и подтверждает проведение авторизации.
        /// </summary>
        [DataMember(Name = "auth_code", IsRequired = false)]
        public string AuthCode { get; set; }
    }
}
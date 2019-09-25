using System.Runtime.Serialization;
using Yandex.Money.Api.Sdk.Kassa.Enums.Payments;

namespace Yandex.Money.Api.Sdk.Kassa.Models.Payments
{
    [DataContract]
    public class Confirmation
    {
        /// <summary>
        ///     Код сценария подтверждения.
        /// </summary>
        [DataMember(Name = "type", IsRequired = true)]
        public ConfirmationType Type { get; set; }

        /// <summary>
        ///     Данные для генерации QR-кода.
        /// </summary>
        [DataMember(Name = "confirmation_data", IsRequired = true)]
        public string ConfirmationData { get; set; }

        /// <summary>
        ///     URL, на который необходимо перенаправить пользователя для подтверждения оплаты.
        /// </summary>
        [DataMember(Name = "confirmation_url", IsRequired = true)]
        public string ConfirmationUrl { get; set; }

        /// <summary>
        ///     Запрос на проведение платежа с аутентификацией по 3-D Secure.
        ///     Будет работать, если оплату банковской картой вы по умолчанию принимаете без подтверждения платежа пользователем.
        ///     В остальных случаях аутентификацией по 3-D Secure будет управлять Яндекс.Касса.
        ///     Если хотите принимать платежи без дополнительного подтверждения пользователем, напишите вашему менеджеру Яндекс.Кассы.
        /// </summary>
        [DataMember(Name = "enforce", IsRequired = false)]
        public bool Enforce { get; set; }

        /// <summary>
        ///     URL, на который вернется пользователь после подтверждения или отмены платежа на веб-странице.
        /// </summary>
        [DataMember(Name = "return_url", IsRequired = false)]
        public string ReturnUrl { get; set; }
    }
}
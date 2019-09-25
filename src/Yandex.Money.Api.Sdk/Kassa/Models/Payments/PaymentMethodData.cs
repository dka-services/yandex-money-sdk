using System.Runtime.Serialization;
using Yandex.Money.Api.Sdk.Kassa.Enums.Payments;

namespace Yandex.Money.Api.Sdk.Kassa.Models.Payments
{
    /// <summary>
    ///     Данные для оплаты конкретным способом  (payment_method).
    ///     Вы можете не передавать этот объект в запросе.
    ///     В этом случае пользователь будет выбирать способ оплаты на стороне Яндекс.Кассы.
    /// </summary>
    [DataContract]
    public class PaymentMethodData
    {
        /// <summary>
        ///     Код способа оплаты
        /// </summary>
        [DataMember(Name = "type", IsRequired = true)]
        public PaymentMethodType Type { get; set; }

        /// <summary>
        ///     Логин пользователя в Альфа-Клике (привязанный телефон или дополнительный логин).
        /// </summary>
        [DataMember(Name = "login", IsRequired = false)]
        public string Login { get; set; }

        /// <summary>
        ///     Телефон пользователя, на который зарегистрирован аккаунт в Сбербанке Онлайн.
        ///     Необходим для подтверждения оплаты по смс (сценарий подтверждения external).
        ///     Указывается в формате ITU-T E.164, например 79000000000.
        /// </summary>
        [DataMember(Name = "phone", IsRequired = false)]
        public string Phone { get; set; }

        /// <summary>
        ///     Данные банковской карты.
        /// </summary>
        [DataMember(Name = "card", IsRequired = false)]
        public Card Card { get; set; }

        /// <summary>
        ///     Назначение платежа (не больше 210 символов).
        /// </summary>
        [DataMember(Name = "payment_purpose", IsRequired = true)]
        public string PaymentPurpose { get; set; }

        /// <summary>
        ///     Данные о налоге на добавленную стоимость (НДС).
        ///     Платеж может облагаться и не облагаться НДС.
        ///     Товары могут облагаться по одной ставке НДС или по разным.
        /// </summary>
        [DataMember(Name = "vat_data", IsRequired = true)]
        public VatData VatData { get; set; }

        /// <summary>
        ///     Содержимое поля paymentData из объекта PKPaymentToken (платежный токен Apple Pay). Приходит в формате Base64.
        /// </summary>
        [DataMember(Name = "payment_data", IsRequired = true)]
        public string PaymentData { get; set; }

        /// <summary>
        ///     Уникальный идентификатор транзакции, выданный Google. Чтобы его получить,
        ///     необходимо вызвать метод PaymentData.getGoogleTransactionId() в мобильном приложении на устройстве пользователя.
        /// </summary>
        [DataMember(Name = "google_transaction_id", IsRequired = true)]
        public string GoogleTransactionId { get; set; }

        /// <summary>
        ///     Криптограмма Payment Token Cryptography для проведения оплаты через Google Pay.
        ///     Чтобы ее получить, необходимо вызвать метод PaymentData.getPaymentMethodToken().getToken() в мобильном приложении на устройстве пользователя.
        /// </summary>
        [DataMember(Name = "payment_method_token", IsRequired = true)]
        public string PaymentMethodToken { get; set; }
    }
}
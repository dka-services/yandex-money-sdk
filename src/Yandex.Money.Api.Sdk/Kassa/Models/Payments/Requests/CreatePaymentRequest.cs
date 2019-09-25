using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Yandex.Money.Api.Sdk.Kassa.Models.Payments.Requests
{
    /// <summary>
    ///     Создание платежа
    ///     <see href="https://kassa.yandex.ru/developers/api?lang=php#create_payment" />
    /// </summary>
    [DataContract]
    public class CreatePaymentRequest
    {
        /// <summary>
        ///     Сумма платежа. Иногда партнеры Яндекс.Кассы берут с пользователя дополнительную комиссию, которая не входит в эту сумму.
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true)]
        public Amount Amount { get; set; }

        /// <summary>
        ///     Описание транзакции (не более 128 символов), которое вы увидите в личном кабинете Яндекс.Кассы, а пользователь — при оплате.
        ///     Например: «Оплата заказа № 72 для user@yandex.ru»
        /// </summary>
        [DataMember(Name = "description", IsRequired = false)]
        public string Description { get; set; }

        /// <summary>
        ///     Данные для формирования чека в онлайн-кассе (для соблюдения 54-ФЗ ).
        /// </summary>
        [DataMember(Name = "receipt", IsRequired = false)]
        public Receipt Receipt { get; set; }

        /// <summary>
        ///     Получатель платежа.
        /// </summary>
        [DataMember(Name = "recipient", IsRequired = false)]
        public Recipient Recipient { get; set; }

        /// <summary>
        ///     Одноразовый токен для проведения оплаты, сформированный с помощью веб или мобильного SDK .
        /// </summary>
        [DataMember(Name = "payment_token", IsRequired = false)]
        public string PaymentToken { get; set; }

        /// <summary>
        ///     Идентификатор сохраненного способа оплаты .
        /// </summary>
        [DataMember(Name = "payment_method_id", IsRequired = false)]
        public string PaymentMethodId { get; set; }

        /// <summary>
        ///     Данные для оплаты конкретным способом  (payment_method).
        ///     Вы можете не передавать этот объект в запросе.
        ///     В этом случае пользователь будет выбирать способ оплаты на стороне Яндекс.Кассы.
        /// </summary>
        [DataMember(Name = "payment_method_data", IsRequired = false)]
        public PaymentMethodData PaymentMethodData { get; set; }

        /// <summary>
        ///     Выбранный способ подтверждения платежа. Присутствует, когда платеж ожидает подтверждения от пользователя.
        ///     Подробнее о сценариях подтверждения
        /// </summary>
        [DataMember(Name = "confirmation", IsRequired = false)]
        public Confirmation Confirmation { get; set; }

        /// <summary>
        ///     Сохранение платежных данных (с их помощью можно проводить повторные безакцептные списания ).
        ///     Значение true инициирует создание многоразового payment_method.
        /// </summary>
        [DataMember(Name = "save_payment_method", IsRequired = false)]
        public bool SavePaymentMethod { get; set; }

        /// <summary>
        ///     Автоматический прием  поступившего платежа.
        /// </summary>
        [DataMember(Name = "capture", IsRequired = false)]
        public bool Capture { get; set; }

        /// <summary>
        ///     IPv4 или IPv6-адрес пользователя. Если не указан, используется IP-адрес TCP-подключения.
        /// </summary>
        [DataMember(Name = "client_ip", IsRequired = false)]
        public string ClientIp { get; set; }

        /// <summary>
        ///     Любые дополнительные данные, которые нужны вам для работы с платежами (например, номер заказа).
        ///     Передаются в виде набора пар «ключ-значение» и возвращаются в ответе от Яндекс.Кассы.
        ///     Ограничения: максимум 16 ключей, имя ключа не больше 32 символов, значение ключа не больше 512 символов.
        /// </summary>
        [DataMember(Name = "metadata", IsRequired = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        ///     Объект с данными для продажи авиабилетов . Используется только для платежей банковской картой.
        /// </summary>
        [DataMember(Name = "airline", IsRequired = false)]
        public Airline Airline { get; set; }
    }
}
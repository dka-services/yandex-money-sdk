using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Yandex.Money.Api.Sdk.Kassa.Enums.Payments;

namespace Yandex.Money.Api.Sdk.Kassa.Models.Payments
{
    /// <summary>
    ///     Объект платежа (Payment) содержит всю информацию о платеже, актуальную на текущий момент времени.
    ///     Он формируется при создании платежа и приходит в ответ на любой запрос, связанный с платежами.
    ///     <see href="https://kassa.yandex.ru/developers/api?lang=php#payment_object" />
    /// </summary>
    [DataContract]
    public class Payment
    {
        /// <summary>
        ///     Идентификатор платежа в Яндекс.Кассе.
        /// </summary>
        [DataMember(Name = "id", IsRequired = true)]
        public string Id { get; set; }

        /// <summary>
        ///     Статус платежа. Возможные значения: pending, waiting_for_capture, succeeded и canceled.
        /// </summary>
        [DataMember(Name = "status", IsRequired = true)]
        public PaymentStatus Status { get; set; }

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
        ///     Получатель платежа.
        /// </summary>
        [DataMember(Name = "recipient", IsRequired = true)]
        public Recipient Recipient { get; set; }

        /// <summary>
        ///     Инициатор платежа или возврата. Инициатором может быть магазин, подключенный к Яндекс.Кассе, (merchant) или приложение,
        ///     которому владелец магазина разрешил  совершать операции от своего имени (third_party_client)
        /// </summary>
        [DataMember(Name = "requestor", IsRequired = true)]
        public Requestor Requestor { get; set; }

        /// <summary>
        ///     Способ оплаты , который был использован для этого платежа.
        /// </summary>
        [DataMember(Name = "payment_method", IsRequired = true)]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        ///     Время подтверждения платежа. Указывается по UTC и передается в формате ISO 8601
        /// </summary>
        [DataMember(Name = "captured_at", IsRequired = false)]
        public DateTime? CapturedAt { get; set; }

        /// <summary>
        ///     Время создания заказа. Указывается по UTC и передается в формате ISO 8601. Пример: 2017-11-03T11:52:31.827Z
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     Время, до которого вы можете бесплатно отменить или подтвердить платеж.
        ///     В указанное время платеж в статусе waiting_for_capture будет автоматически отменен.
        ///     Указывается по UTC и передается в формате ISO 8601. Пример: 2017-11-03T11:52:31.827Z
        /// </summary>
        [DataMember(Name = "expires_at", IsRequired = false)]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        ///     Выбранный способ подтверждения платежа. Присутствует, когда платеж ожидает подтверждения от пользователя.
        ///     Подробнее о сценариях подтверждения
        /// </summary>
        [DataMember(Name = "confirmation", IsRequired = false)]
        public Confirmation Confirmation { get; set; }

        /// <summary>
        ///     Признак тестовой операции.
        /// </summary>
        [DataMember(Name = "test", IsRequired = true)]
        public bool Test { get; set; }

        /// <summary>
        ///     Сумма, которая вернулась пользователю. Присутствует, если у этого платежа есть успешные возвраты.
        /// </summary>
        [DataMember(Name = "refunded_amount", IsRequired = false)]
        public RefundedAmount RefundedAmount { get; set; }

        /// <summary>
        ///     Признак оплаты заказа.
        /// </summary>
        [DataMember(Name = "paid", IsRequired = true)]
        public bool Paid { get; set; }

        /// <summary>
        ///     Возможность провести возврат по API.
        /// </summary>
        [DataMember(Name = "refundable", IsRequired = true)]
        public bool Refundable { get; set; }

        /// <summary>
        ///     Статус доставки данных для чека в онлайн-кассу (pending, succeeded или canceled).
        ///     Присутствует, если вы используете решение Яндекс.Кассы для работы по 54-ФЗ .
        /// </summary>
        [DataMember(Name = "receipt_registration", IsRequired = false)]
        public ReceiptRegistration ReceiptRegistration { get; set; }

        /// <summary>
        ///     Любые дополнительные данные, которые нужны вам для работы с платежами (например, номер заказа).
        ///     Передаются в виде набора пар «ключ-значение» и возвращаются в ответе от Яндекс.Кассы.
        ///     Ограничения: максимум 16 ключей, имя ключа не больше 32 символов, значение ключа не больше 512 символов.
        /// </summary>
        [DataMember(Name = "metadata", IsRequired = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        ///     Комментарий к статусу canceled: кто отменил платеж и по какой причине. Подробнее про неуспешные платежи
        /// </summary>
        [DataMember(Name = "cancellation_details", IsRequired = false)]
        public CancellationDetails CancellationDetails { get; set; }

        /// <summary>
        ///     Данные об авторизации платежа.
        /// </summary>
        [DataMember(Name = "authorization_details", IsRequired = false)]
        public AuthorizationDetails AuthorizationDetails { get; set; }
    }
}
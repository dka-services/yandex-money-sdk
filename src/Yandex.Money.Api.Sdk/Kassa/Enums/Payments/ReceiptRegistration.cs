using System.Runtime.Serialization;

namespace Yandex.Money.Api.Sdk.Kassa.Enums.Payments
{
    /// <summary>
    ///     Статус доставки данных для чека в онлайн-кассу (pending, succeeded или canceled).
    ///     Присутствует, если вы используете решение Яндекс.Кассы для работы по 54-ФЗ .
    /// </summary>
    public enum ReceiptRegistration
    {
        [EnumMember(Value = "pending")] Pending,
        [EnumMember(Value = "succeeded")] Succeeded,
        [EnumMember(Value = "canceled")] Canceled
    }
}
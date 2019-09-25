using System.Runtime.Serialization;

namespace Yandex.Money.Api.Sdk.Kassa.Enums.Payments
{
    /// <summary>
    ///     Статус платежа. Возможные значения: pending, waiting_for_capture, succeeded и canceled.
    /// </summary>
    public enum PaymentStatus
    {
        [EnumMember(Value = "pending")] Pending,

        [EnumMember(Value = "waiting_for_capture")]
        WaitingForCapture,
        [EnumMember(Value = "succeeded")] Succeeded,
        [EnumMember(Value = "canceled")] Canceled
    }
}
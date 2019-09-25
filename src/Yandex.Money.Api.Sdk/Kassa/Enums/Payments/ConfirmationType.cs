using System.Runtime.Serialization;

namespace Yandex.Money.Api.Sdk.Kassa.Enums.Payments
{
    /// <summary>
    ///     Код сценария подтверждения.
    /// </summary>
    public enum ConfirmationType
    {
        [EnumMember(Value = "external")] External,

        [EnumMember(Value = "qr")] Qr,

        [EnumMember(Value = "redirect")] Redirect
    }
}
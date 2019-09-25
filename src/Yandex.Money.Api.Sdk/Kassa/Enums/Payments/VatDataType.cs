using System.Runtime.Serialization;

namespace Yandex.Money.Api.Sdk.Kassa.Enums.Payments
{
    /// <summary>
    ///     Код способа расчета НДС.
    /// </summary>
    public enum VatDataType
    {
        [EnumMember(Value = "calculated")] Calculated,
        [EnumMember(Value = "untaxed")] Untaxed,
        [EnumMember(Value = "mixed")] Mixed
    }
}
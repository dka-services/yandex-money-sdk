using System.Runtime.Serialization;

namespace Yandex.Money.Api.Sdk.Kassa.Enums.Payments
{
    /// <summary>
    ///     Тип инициатора.
    /// </summary>
    public enum RequestorType
    {
        [EnumMember(Value = "merchant")] Merchant,

        [EnumMember(Value = "third_party_client")]
        ThirdPartyClient
    }
}
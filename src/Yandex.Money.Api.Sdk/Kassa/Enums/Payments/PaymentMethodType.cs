using System.Runtime.Serialization;

namespace Yandex.Money.Api.Sdk.Kassa.Enums.Payments
{
    /// <summary>
    ///     Способы оплаты
    ///     <see href="https://kassa.yandex.ru/developers/payments/basics/payment-methods" />
    /// </summary>
    public enum PaymentMethodType
    {
        [EnumMember(Value = "bank_card")] BankCard,

        [EnumMember(Value = "apple_pay")] ApplePay,

        [EnumMember(Value = "google_pay")] GooglePay,

        #region Электронные деньги

        [EnumMember(Value = "yandex_money")] YandexMoney,

        [EnumMember(Value = "qiwi")] Qiwi,

        [EnumMember(Value = "webmoney")] Webmoney,

        [EnumMember(Value = "wechat")] WeChat,

        #endregion

        #region Интернет-банкинг

        [EnumMember(Value = "sberbank")] Sberbank,

        [EnumMember(Value = "alfabank")] Alfabank,

        [EnumMember(Value = "tinkoff_bank")] Tinkoffbank,

        #endregion

        #region B2B-платежи

        [EnumMember(Value = "b2b_sberbank")] B2BSberbank,

        #endregion

        #region Другие способы

        [EnumMember(Value = "mobile_balance")] MobileBalance,

        [EnumMember(Value = "cash")] Cash,

        [EnumMember(Value = "installments")] Installments

        #endregion
    }
}
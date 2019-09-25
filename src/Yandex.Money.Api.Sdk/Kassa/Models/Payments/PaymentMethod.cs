using System.Runtime.Serialization;
using JsonSubTypes;
using Newtonsoft.Json;
using Yandex.Money.Api.Sdk.Kassa.Enums.Payments;

namespace Yandex.Money.Api.Sdk.Kassa.Models.Payments
{
    /// <summary>
    ///     Способ оплаты , который был использован для этого платежа.
    ///     <see href="https://kassa.yandex.ru/developers/payments/basics/payment-methods" />
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes))]
    public class PaymentMethod
    {
        private PaymentMethod()
        {

        }
        protected PaymentMethod(
            string id,
            bool saved,
            string title
        ) : this()
        {
            Id = id;
            Saved = saved;
            Title = title;
        }

        /// <summary>
        ///     Идентификатор способа оплаты.
        /// </summary>
        [DataMember(Name = "id", IsRequired = true)]
        protected string Id { get; set; }

        /// <summary>
        ///     Код способа оплаты
        /// </summary>
        [DataMember(Name = "type", IsRequired = true)]
        protected PaymentMethodType Type { get; set; }

        /// <summary>
        ///     С помощью сохраненного способа оплаты можно проводить безакцептные списания.
        /// </summary>
        [DataMember(Name = "saved", IsRequired = true)]
        protected bool Saved { get; set; }

        /// <summary>
        ///     Название способа оплаты.
        /// </summary>
        [DataMember(Name = "title", IsRequired = false)]
        protected string Title { get; set; }
    }

    #region BankCard

    /// <summary>
    ///     Банковская карта
    /// </summary>
    [DataContract]
    public class BankCardPaymentMethod : PaymentMethod
    {
        /// <summary>
        ///     Create Bank Card
        /// </summary>
        /// <param name="id"></param>
        /// <param name="saved"></param>
        /// <param name="title"></param>
        /// <param name="card"></param>
        public BankCardPaymentMethod(string id, bool saved, string title, Card card) : base(id, saved, title)
        {
            Type = PaymentMethodType.BankCard;
            Card = card;
        }

        /// <summary>
        ///     Данные банковской карты.
        /// </summary>
        [DataMember(Name = "card", IsRequired = false)]
        public Card Card { get; private set; }
    }

    #endregion

    #region ApplePay

    /// <summary>
    ///     ApplePay
    /// </summary>
    [DataContract]
    public class ApplePayPaymentMethod : PaymentMethod
    {
        /// <summary>
        ///     Create Apple Pay
        /// </summary>
        /// <param name="id"></param>
        /// <param name="saved"></param>
        /// <param name="title"></param>
        public ApplePayPaymentMethod(string id, bool saved, string title) : base(id, saved, title)
        {
            Type = PaymentMethodType.ApplePay;
        }
    }

    #endregion

    #region GooglePay

    /// <summary>
    ///     ApplePay
    /// </summary>
    [DataContract]
    public class GooglePayPaymentMethod : PaymentMethod
    {
        /// <summary>
        ///     Create Apple Pay
        /// </summary>
        /// <param name="id"></param>
        /// <param name="saved"></param>
        /// <param name="title"></param>
        public GooglePayPaymentMethod(string id, bool saved, string title) : base(id, saved, title)
        {
            Type = PaymentMethodType.GooglePay;
        }
    }

    #endregion

    #region Электронные деньги

    #region YandexMoney

    /// <summary>
    ///     YandexMoney
    /// </summary>
    [DataContract]
    public class YandexMoneyPaymentMethod : PaymentMethod
    {
        /// <summary>
        ///     Create Yandex Money
        /// </summary>
        /// <param name="id"></param>
        /// <param name="saved"></param>
        /// <param name="title"></param>
        /// <param name="accountNumber"></param>
        public YandexMoneyPaymentMethod(
            string id,
            bool saved,
            string title,
            string accountNumber
        ) : base(id, saved, title)
        {
            Type = PaymentMethodType.YandexMoney;
            AccountNumber = accountNumber;
        }

        /// <summary>
        ///     Номер кошелька в Яндекс.Деньгах, из которого заплатил пользователь.
        /// </summary>
        [DataMember(Name = "account_number", IsRequired = false)]
        public string AccountNumber { get; private set; }
    }

    #endregion

    #region Qiwi

    /// <summary>
    ///     Qiwi
    /// </summary>
    [DataContract]
    public class QiwiPaymentMethod : PaymentMethod
    {
        /// <summary>
        ///     Create Qiwi
        /// </summary>
        /// <param name="id"></param>
        /// <param name="saved"></param>
        /// <param name="title"></param>
        public QiwiPaymentMethod(string id, bool saved, string title) : base(id, saved, title)
        {
            Type = PaymentMethodType.Qiwi;
        }
    }

    #endregion

    #region Webmoney

    /// <summary>
    ///     Webmoney
    /// </summary>
    [DataContract]
    public class WebmoneyPaymentMethod : PaymentMethod
    {
        /// <summary>
        ///     Create Webmoney
        /// </summary>
        /// <param name="id"></param>
        /// <param name="saved"></param>
        /// <param name="title"></param>
        public WebmoneyPaymentMethod(string id, bool saved, string title) : base(id, saved, title)
        {
            Type = PaymentMethodType.Webmoney;
        }
    }

    #endregion

    #region WeChat

    /// <summary>
    ///     WeChat
    /// </summary>
    [DataContract]
    public class WeChatPaymentMethod : PaymentMethod
    {
        /// <summary>
        ///     Create WeChat
        /// </summary>
        /// <param name="id"></param>
        /// <param name="saved"></param>
        /// <param name="title"></param>
        public WeChatPaymentMethod(string id, bool saved, string title) : base(id, saved, title)
        {
            Type = PaymentMethodType.WeChat;
        }
    }

    #endregion

    #endregion

    #region Интернет-банкинг

    #region Sberbank

    /// <summary>
    ///     Sberbank
    /// </summary>
    [DataContract]
    public class SberbankPaymentMethod : PaymentMethod
    {
        /// <summary>
        ///     Create Sberbank
        /// </summary>
        /// <param name="id"></param>
        /// <param name="saved"></param>
        /// <param name="title"></param>
        /// <param name="phone"></param>
        public SberbankPaymentMethod(
            string id,
            bool saved,
            string title,
            string phone
        ) : base(id, saved, title)
        {
            Type = PaymentMethodType.Sberbank;
            Phone = phone;
        }

        /// <summary>
        ///     Телефон пользователя, на который зарегистрирован аккаунт в Сбербанке Онлайн.
        ///     Необходим для подтверждения оплаты по смс (сценарий подтверждения external).
        ///     Указывается в формате ITU-T E.164, например 79000000000.
        /// </summary>
        [DataMember(Name = "phone", IsRequired = false)]
        public string Phone { get; private set; }
    }

    #endregion

    #region Alfabank

    /// <summary>
    ///     Alfabank
    /// </summary>
    [DataContract]
    public class AlfabankPaymentMethod : PaymentMethod
    {
        /// <summary>
        ///     Create Alfabank
        /// </summary>
        /// <param name="id"></param>
        /// <param name="saved"></param>
        /// <param name="title"></param>
        /// <param name="login"></param>
        public AlfabankPaymentMethod(string id, bool saved, string title, string login) : base(id, saved, title)
        {
            Type = PaymentMethodType.Alfabank;
            Login = login;
        }

        /// <summary>
        ///     Логин пользователя в Альфа-Клике (привязанный телефон или дополнительный логин).
        /// </summary>
        [DataMember(Name = "login", IsRequired = false)]
        public string Login { get; private set; }
    }

    #endregion

    #region Tinkoffbank

    /// <summary>
    ///     Tinkoffbank
    /// </summary>
    [DataContract]
    public class TinkoffbankPaymentMethod : PaymentMethod
    {
        /// <summary>
        ///     Create Tinkoffbank
        /// </summary>
        /// <param name="id"></param>
        /// <param name="saved"></param>
        /// <param name="title"></param>
        public TinkoffbankPaymentMethod(string id, bool saved, string title) : base(id, saved, title)
        {
            Type = PaymentMethodType.Tinkoffbank;
        }
    }

    #endregion

    #endregion

    #region B2B-платежи

    #region B2BSberbank

    /// <summary>
    ///     B2BSberbank
    /// </summary>
    [DataContract]
    public class B2BSberbankPaymentMethod : PaymentMethod
    {
        /// <summary>
        ///     Create Tinkoffbank
        /// </summary>
        /// <param name="id"></param>
        /// <param name="saved"></param>
        /// <param name="title"></param>
        /// <param name="payerBankDetails"></param>
        /// <param name="paymentPurpose"></param>
        /// <param name="vatData"></param>
        public B2BSberbankPaymentMethod(
            string id,
            bool saved,
            string title,
            PayerBankDetails payerBankDetails,
            string paymentPurpose,
            VatData vatData) : base(id, saved, title)
        {
            Type = PaymentMethodType.B2BSberbank;
            PayerBankDetails = payerBankDetails;
            PaymentPurpose = paymentPurpose;
            VatData = vatData;
        }

        /// <summary>
        ///     Банковские реквизиты плательщика (юридического лица или ИП).
        /// </summary>
        [DataMember(Name = "payer_bank_details", IsRequired = true)]
        public PayerBankDetails PayerBankDetails { get; private set; }

        /// <summary>
        ///     Назначение платежа (не больше 210 символов).
        /// </summary>
        [DataMember(Name = "payment_purpose", IsRequired = true)]
        public string PaymentPurpose { get; private set; }

        /// <summary>
        ///     Данные о налоге на добавленную стоимость (НДС).
        ///     Платеж может облагаться и не облагаться НДС.
        ///     Товары могут облагаться по одной ставке НДС или по разным.
        /// </summary>
        [DataMember(Name = "vat_data", IsRequired = true)]
        public VatData VatData { get; private set; }
    }

    #endregion

    #endregion

    #region Другие способы

    #region MobileBalance

    /// <summary>
    ///     MobileBalance
    /// </summary>
    [DataContract]
    public class MobileBalancePaymentMethod : PaymentMethod
    {
        /// <summary>
        ///     Create MobileBalance
        /// </summary>
        /// <param name="id"></param>
        /// <param name="saved"></param>
        /// <param name="title"></param>
        public MobileBalancePaymentMethod(string id, bool saved, string title) : base(id, saved, title)
        {
            Type = PaymentMethodType.MobileBalance;
        }
    }

    #endregion

    #region Cash

    /// <summary>
    ///     Cash
    /// </summary>
    [DataContract]
    public class CashPaymentMethod : PaymentMethod
    {
        /// <summary>
        ///     Create Cash
        /// </summary>
        /// <param name="id"></param>
        /// <param name="saved"></param>
        /// <param name="title"></param>
        public CashPaymentMethod(string id, bool saved, string title) : base(id, saved, title)
        {
            Type = PaymentMethodType.Cash;
        }
    }

    #endregion

    #region Installments

    /// <summary>
    ///     Installments
    /// </summary>
    [DataContract]
    public class InstallmentsPaymentMethod : PaymentMethod
    {
        /// <summary>
        ///     Create Installments
        /// </summary>
        /// <param name="id"></param>
        /// <param name="saved"></param>
        /// <param name="title"></param>
        public InstallmentsPaymentMethod(string id, bool saved, string title) : base(id, saved, title)
        {
            Type = PaymentMethodType.Installments;
        }
    }

    #endregion

    #endregion
}
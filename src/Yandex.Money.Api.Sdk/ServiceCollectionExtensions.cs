using System;
using JsonSubTypes;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Yandex.Money.Api.Sdk.Kassa;
using Yandex.Money.Api.Sdk.Kassa.Enums.Payments;
using Yandex.Money.Api.Sdk.Kassa.Models.Payments;
using Yandex.Money.Api.Sdk.Kassa.Services.Payments;

namespace Yandex.Money.Api.Sdk
{
    public static class ServiceCollectionExtensions
    {
        public static void AddYandexKassa(this IServiceCollection services, Action<Configuration> configure)
        {
            var cfg = new Configuration();
            configure(cfg);

            services.AddSingleton(cfg);
            services.AddSingleton<IPaymentService, PaymentService>();

            var settings = new JsonSerializerSettings();
            JsonConvert.DefaultSettings = () => settings;

            settings.Converters.Add(JsonSubtypesConverterBuilder
                                   .Of(typeof(PaymentMethod), "Id")
                                   .SerializeDiscriminatorProperty()
                                   .RegisterSubtype(typeof(BankCardPaymentMethod), PaymentMethodType.BankCard)
                                   .RegisterSubtype(typeof(ApplePayPaymentMethod), PaymentMethodType.ApplePay)
                                   .RegisterSubtype(typeof(GooglePayPaymentMethod), PaymentMethodType.GooglePay)
                                   .RegisterSubtype(typeof(YandexMoneyPaymentMethod), PaymentMethodType.YandexMoney)
                                   .RegisterSubtype(typeof(QiwiPaymentMethod), PaymentMethodType.Qiwi)
                                   .RegisterSubtype(typeof(WebmoneyPaymentMethod), PaymentMethodType.Webmoney)
                                   .RegisterSubtype(typeof(WeChatPaymentMethod), PaymentMethodType.WeChat)
                                   .RegisterSubtype(typeof(SberbankPaymentMethod), PaymentMethodType.Sberbank)
                                   .RegisterSubtype(typeof(AlfabankPaymentMethod), PaymentMethodType.Alfabank)
                                   .RegisterSubtype(typeof(TinkoffbankPaymentMethod), PaymentMethodType.Tinkoffbank)
                                   .RegisterSubtype(typeof(B2BSberbankPaymentMethod), PaymentMethodType.B2BSberbank)
                                   .RegisterSubtype(typeof(MobileBalancePaymentMethod), PaymentMethodType.MobileBalance)
                                   .RegisterSubtype(typeof(CashPaymentMethod), PaymentMethodType.Cash)
                                   .RegisterSubtype(typeof(InstallmentsPaymentMethod), PaymentMethodType.Installments)
                                   .Build());
        }
    }
}
using System;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Yandex.Money.Api.Sdk.Core.Http;
using Yandex.Money.Api.Sdk.Kassa.Models.Payments;
using Yandex.Money.Api.Sdk.Kassa.Models.Payments.Requests;

namespace Yandex.Money.Api.Sdk.Kassa.Services.Payments
{
    public class PaymentService : IPaymentService
    {
        private readonly Configuration _configuration;

        public PaymentService([NotNull] Configuration configuration)
        {
            _configuration = configuration;
        }

        private IRequest Http => Core.Http.Http.Open(_configuration.ApiUrl)
                                       .BasicAuthorization(_configuration.ShopId, _configuration.ShopSecret);

        /// <summary>
        ///     Payment creation
        /// </summary>
        /// <param name="payment">Payment information, <see cref="CreatePaymentRequest" /></param>
        /// <param name="cancellationToken">
        ///     <see cref="CancellationToken" />
        /// </param>
        /// <param name="idempotenceKey">
        ///     Idempotence key, use
        ///     <value>null</value>
        ///     to generate a new one
        /// </param>
        /// <returns>
        ///     <see cref="Payment" />
        /// </returns>
        public async Task<Payment> CreatePaymentAsync([NotNull] CreatePaymentRequest payment, string idempotenceKey = null, CancellationToken cancellationToken = default)
        {
            if (payment == null) throw new ArgumentNullException(nameof(payment));

            if (!string.IsNullOrEmpty(idempotenceKey))
                Http.Header("Idempotence-Key", idempotenceKey);

            return await Http.Get("/payments").JsonContent(payment).AsAsync<Payment>();
        }

        /// <summary>
        ///     Get payment state
        /// </summary>
        /// <param name="id">Payment id, <see cref="Payment.Id" /></param>
        /// <param name="cancellationToken">
        ///     <see cref="CancellationToken" />
        /// </param>
        /// <returns>
        ///     <see cref="Payment" />
        /// </returns>
        public async Task<Payment> GetPaymentAsync([NotNull] string id, CancellationToken cancellationToken = default)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            return await Http.Get($"payments/{id}").AsAsync<Payment>();
        }
    }
}
using System.Threading;
using System.Threading.Tasks;
using Yandex.Money.Api.Sdk.Kassa.Models.Payments;
using Yandex.Money.Api.Sdk.Kassa.Models.Payments.Requests;

namespace Yandex.Money.Api.Sdk.Kassa.Services.Payments
{
    public interface IPaymentService
    {
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
        Task<Payment> CreatePaymentAsync(CreatePaymentRequest payment, string idempotenceKey = null, CancellationToken cancellationToken = default);

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
        Task<Payment> GetPaymentAsync(string id, CancellationToken cancellationToken = default);
    }
}
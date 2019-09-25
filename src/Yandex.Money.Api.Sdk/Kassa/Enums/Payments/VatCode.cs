namespace Yandex.Money.Api.Sdk.Kassa.Enums.Payments
{
    /// <summary>
    ///     Коды НДС
    ///     <see href="https://kassa.yandex.ru/developers/payments/54fz/parameters-values#vat-codes" />
    /// </summary>
    public enum VatCode
    {
        /// <summary>
        ///     Без НДС
        /// </summary>
        NoVat = 1,

        /// <summary>
        ///     НДС по ставке 0%
        /// </summary>
        Vat0 = 2,

        /// <summary>
        ///     НДС по ставке 10%
        /// </summary>
        Vat10 = 3,

        /// <summary>
        ///     НДС по ставке 20%
        /// </summary>
        Vat20 = 4,

        /// <summary>
        ///     НДС по расчетной ставке 10/110
        /// </summary>
        Vat110 = 5,

        /// <summary>
        ///     НДС чека по расчетной ставке 20/120
        /// </summary>
        Vat120 = 6
    }
}
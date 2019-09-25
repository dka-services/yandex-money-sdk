using System.Runtime.Serialization;

namespace Yandex.Money.Api.Sdk.Kassa.Models.Payments
{
    /// <summary>
    ///     Список перелетов.
    /// </summary>
    [DataContract]
    public class Legs
    {
        /// <summary>
        ///     Код аэропорта вылета по справочнику IATA, например LED.
        /// </summary>
        [DataMember(Name = "departure_airport", IsRequired = true)]
        public string DepartureAirport { get; set; }

        /// <summary>
        ///     Код аэропорта прилета по справочнику IATA, например AMS.
        /// </summary>
        [DataMember(Name = "destination_airport", IsRequired = true)]
        public string DestinationAirport { get; set; }

        /// <summary>
        ///     Дата вылета в формате YYYY-MM-DD по стандарту ISO 8601:2004.
        /// </summary>
        [DataMember(Name = "departure_date", IsRequired = true)]
        public string DepartureDate { get; set; }

        /// <summary>
        ///     Код авиакомпании по справочнику IATA.
        /// </summary>
        [DataMember(Name = "carrier_code", IsRequired = false)]
        public string CarrierCode { get; set; }
    }
}
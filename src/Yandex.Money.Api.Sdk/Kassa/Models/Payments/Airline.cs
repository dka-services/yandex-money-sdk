using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Yandex.Money.Api.Sdk.Kassa.Models.Payments
{
    /// <summary>
    ///     Объект с данными для продажи авиабилетов . Используется только для платежей банковской картой.
    /// </summary>
    [DataContract]
    public class Airline
    {
        /// <summary>
        ///     Уникальный номер билета. Если при создании платежа вы уже знаете номер билета, тогда ticket_number — обязательный параметр.
        ///     Если не знаете, тогда вместо ticket_number необходимо передать booking_reference с номером бронирования.
        /// </summary>
        [DataMember(Name = "ticket_number", IsRequired = false)]
        public string TicketNumber { get; set; }

        /// <summary>
        ///     Номер бронирования. Обязателен, если не передан ticket_number.
        /// </summary>
        [DataMember(Name = "booking_reference", IsRequired = false)]
        public string BookingReference { get; set; }

        /// <summary>
        ///     Список пассажиров.
        /// </summary>
        [DataMember(Name = "passengers", IsRequired = false)]
        public ICollection<Passengers> Passengers { get; set; } = new List<Passengers>();

        /// <summary>
        ///     Список перелетов.
        /// </summary>
        [DataMember(Name = "legs", IsRequired = false)]
        public ICollection<Legs> Legs { get; set; } = new List<Legs>();
    }
}
using System.Runtime.Serialization;

namespace Yandex.Money.Api.Sdk.Kassa.Models.Payments
{
    /// <summary>
    ///     Список пассажиров.
    /// </summary>
    [DataContract]
    public class Passengers
    {
        /// <summary>
        ///     Имя пассажира.
        /// </summary>
        [DataMember(Name = "first_name", IsRequired = true)]
        public string FirstName { get; set; }

        /// <summary>
        ///     Фамилия пассажира.
        /// </summary>
        [DataMember(Name = "last_name", IsRequired = true)]
        public string LastName { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Mvc.Core.Models
{
    /// <summary>
    /// Address
    /// </summary>
    [Table("Address")]
    public class Address
    {
        /// <summary>
        /// AddressId
        /// </summary>
        public int AddressId { get; set; }
        /// <summary>
        /// AddressLine1
        /// </summary>
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string CountryRegion { get; set; }
        public string PostalCode { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

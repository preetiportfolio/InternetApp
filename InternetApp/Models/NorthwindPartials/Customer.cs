using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InternetApp.Models.Northwind
{
    [MetadataType(typeof(CustomerMetaData))]
    public partial class Customer { }
   
    public class CustomerMetaData
    {
        [Required]
        [Display(Name = "Company")]
        public object CompanyName { get; set; }

        [Required]
        [Display(Name = "Contact")]
        public object ContactName { get; set; }

        [Required]
        [Display(Name = "Title")]
        public object ContactTitle { get; set; }

        [Required]
        [Display(Name = "City")]
        public object City { get; set; }

    }
}
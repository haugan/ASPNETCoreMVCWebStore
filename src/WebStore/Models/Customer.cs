using System;
using System.ComponentModel.DataAnnotations;

namespace WebStore.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required, StringLength(63), Display(Name = "Last name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string LastName { get; set; }

        [Required, StringLength(63), Display(Name = "First name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string FirstName { get; set; }
        
        [StringLength(127), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        // DateTime er alltid [Required]
        // DataType gir HTML (data-dash) attributter som HTML5 browsere kan forstå (altså ingen validering)!
        // DataType.Date datafelt vises i defaultformat satt i servers CultureInfo-objekt.
        [DataType(DataType.Date)] 
        public DateTime Birthday { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingApplication.Models
{
    public class Client
    {
        [Required]        
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        [EmailAddress]
        [Remote("VerifyEmail", "Client")]
        //pirmas Action name, antras controllr name
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? ContactDate { get; set; }
        [Required]
        public string ClientType { get; set; }
        [Required]
        public string NearestLocation { get; set; }
        [Required]
        [MaxLength(25), DataType(DataType.MultilineText)]
        [UIHint("MultilineTextLarge")]
        public string Notes { get; set; }
        public List<EmailPromo> EmailPromos { get; set; }
        [Required]
        public Address BillingAddress { get; set; }
        [Required]
        public Address MailingAddress { get; set; }
    }
}

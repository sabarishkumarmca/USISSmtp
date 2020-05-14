using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace USISSmtp.Models
{
    public class EmailNotification
    {
        [Required]
        [Display(Name = "To (Email Address)")]
        [EmailAddress]
        public string ToEmail { get; set; }
    }
}
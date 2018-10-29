using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace hw5.Models
{
    public class ApartRequestForm
    {
        [Key]
        public int ID { get; set; }

        [Required, StringLength(20)]
        public string FirstName { get; set; }

        [Required, StringLength(20)]
        public string LastName { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        public string ApartName { get; set; }

        [Required]
        public int UninNum { get; set; }

        public string CurrTime
        {
            get
            {
               return DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            }
        }
    }
}
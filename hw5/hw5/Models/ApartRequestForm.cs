using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace hw5.Models
{
    public class ApartRequestForm
    {

        /// <summary>
        /// Primary KEY Modeling
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// DB Attributes Modeling
        /// </summary>
        [Required, StringLength(20)]
        public string FirstName { get; set; }

        [Required, StringLength(20)]
        public string LastName { get; set; }

        [Required, StringLength(12)]
        public string PhoneNumber { get; set; }

        [Required]
        public string ApartName { get; set; }

        [Required]
        public string Details { get; set; }

        [Required]
        public int UnitNum { get; set; }

        [Required]
        public bool Permission { get; set; }

        /// <summary>
        /// Giving Current Time when request Submit
        /// </summary>
        private DateTime date = DateTime.Now;
        public DateTime CurrTime
        {
            get { return date; }
            set { date = value; }
        }
    }
}
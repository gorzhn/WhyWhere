using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WhyWhere.Models
{
    public class UserReview
    {
        public int ID { get; set; }

        [Display(Name = "Опис")]
        public string reviewDescription { get; set; }
        [Display(Name = "Локација")]
        public string Name { get; set; }




    }
}
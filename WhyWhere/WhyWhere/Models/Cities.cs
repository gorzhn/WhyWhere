using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WhyWhere.Models
{
    public class Cities
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Url")]
        public string ImgUrl { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        
        public string selectedCity { get; set; }
        [Display(Name = "Држава")]
        public string country { get; set; }



    }
}
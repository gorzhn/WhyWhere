using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WhyWhere.Models
{
    public class Locations
    {
        [Key]
        public int Id { get; set; }
        //info
        [Required]
        [Display(Name="Град")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Url")]
        public string ImgUrl { get; set; }
        [Required]
        [Display(Name = "Име")]
        public string Name { get; set; }
        [Display(Name = "Опис")]
        public string Description { get; set; }


        // for the rating
        public int? UserId { get; set; }
        public int? UserRating { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }
}
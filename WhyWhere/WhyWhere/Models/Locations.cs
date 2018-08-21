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
        public string City { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        [Required]
        public string Name { get; set; }
        
        public string Description { get; set; }


        // for the rating
        public int? UserId { get; set; }
        public int? UserRating { get; set; }
        
        

    }
}
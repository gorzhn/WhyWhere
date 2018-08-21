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


        public string ImgUrl { get; set; }
        public string Name { get; set; }
        public string selectedCity { get; set; }

        public string country { get; set; }



    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WhyWhere.Models
{
    public class CountryModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string selectedCountry { get; set; }

        public List<CountryModel> countries;


        public CountryModel() {
            countries = new List<CountryModel>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
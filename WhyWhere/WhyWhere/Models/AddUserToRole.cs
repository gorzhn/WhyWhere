using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WhyWhere.Models
{
    public class AddUserToRole
    {
         public int Id { get; set; }
         public int IdFortaking { get; set; } 

         public string Email { get; set; }
       
         public string selectedRole { get; set; }

         public List<string> roles;



        public AddUserToRole() {
            roles = new List<string>();
      
        }

        public override string ToString()
        {
            return Email;
        }

    }
}
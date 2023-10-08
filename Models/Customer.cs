using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventFlow.Models
{
    public class Customer
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Email { get; set; }
        [Required] public string Password { get; set; }
        [Required] public string PhoneNumber { get; set; }
        [Required] public string Role { get; set; }


        public static string CheckLogin(string email, string password)
        {
            if(DatabaseModel.db.Users.Any(x => x.Email == email && x.Password == password))
            {
                return "200";
            }
            else
            {
                return "300";
            }
            
        }

    }


}
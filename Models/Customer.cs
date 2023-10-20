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

        //Finding Methods
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

        //Editing Methods
        public static string Register(Customer user)
        {
            try 
            {
                if (user != null)
                {
                    DatabaseModel.db.Users.Add(user);
                    DatabaseModel.db.SaveChanges();
                    return "200";
                }
                else
                {
                    return "Error";
                }
                
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }

    }


}
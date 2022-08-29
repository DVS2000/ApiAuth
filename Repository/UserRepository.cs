using ApiAuth.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApiAuth.Repository
{
    public class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new User
                {
                    Id = 1,
                    Username = "Dorivaldo",
                    Password = "Dorivaldo",
                    Role = "manager"
                },

                new User
                {
                    Id = 1,
                    Username = "Edvaldo",
                    Password = "Edvaldo",
                    Role = "employee"
                }
            };

            return users.FirstOrDefault(
                x => x.Username.ToLower() == username.ToLower() 
                  && x.Password.ToLower() == password.ToLower()
               );
        }
    }
}

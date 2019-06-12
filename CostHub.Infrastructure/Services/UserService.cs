using CostHub.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostHub.Infrastructure.Services
{
    public class UserService
    {
        private List<User> Users = new List<User>
        {
            new User("Kamil", "Krawczyk", "kraszian", "krawczyk.kamil@hotmail.com"),
            new User("Jedrzej", "Krawczyk", "kraszian", "krawczyk.kamil@hotmail.com")
        };

        public List<User> BrowseUsers()
            => Users;

        public string AddUser(string firstName, string lastName, string login, string email)
        {
            var usr = new User(firstName, lastName, login, email);
            return "";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostHub.Core.Domain
{
    public class User
    {
        public int Id { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Login { get; protected set; }
        public string Email { get; protected set; }
        public DateTime DateCreated { get; protected set; }

        public User(int id, string firstName, string lastName, string login, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Login = login;
            Email = email;
            DateCreated = DateTime.UtcNow;
        }
        public User(string firstName, string lastName, string login, string email)
        {
            Id = 0;
            FirstName = firstName;
            LastName = lastName;
            Login = login;
            Email = email;
            DateCreated = DateTime.UtcNow;
        }
    }
}

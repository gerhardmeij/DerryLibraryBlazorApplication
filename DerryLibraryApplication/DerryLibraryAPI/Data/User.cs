using System;
using System.Collections.Generic;

#nullable disable

namespace DerryLibraryAPI.Data
{
    public partial class User
    {
        public User()
        {
            Transactions = new HashSet<Transaction>();
            UserRoles = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PassKey { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}

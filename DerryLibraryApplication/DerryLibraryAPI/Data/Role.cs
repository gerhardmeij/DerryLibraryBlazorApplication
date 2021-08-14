using System;
using System.Collections.Generic;

#nullable disable

namespace DerryLibraryAPI.Data
{
    public partial class Role
    {
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}

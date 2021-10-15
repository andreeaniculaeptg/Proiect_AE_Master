using System;
using System.Collections.Generic;

#nullable disable

namespace Puzzle4UbyNAM.Models.Entites
{
    public partial class AspNetUser : IEntity<string>
    {
        public string Id { get; set; }

        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public Nullable<System.DateTime> LockoutEnd { get; set; }   //AA !!!
        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        public virtual ICollection<AspNetUserClaim> AspNetUserClaims{ get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
    }
}

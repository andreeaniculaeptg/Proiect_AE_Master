using System;
using System.Collections.Generic;

#nullable disable

namespace Puzzle4UbyNAM.Models.Entites
{
    public partial class AspNetUserLogin : IEntity<string>
    {
        public string Id { get; set; }

        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string UserId { get; set; }
        
        public virtual ICollection<AspNetUser> AspNetUsers{ get; set; }
    }
}

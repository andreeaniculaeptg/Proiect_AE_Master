using System;
using System.Collections.Generic;

#nullable disable

namespace Puzzle4UbyNAM.Models.Entites
{
    public partial class AspNetRole : IEntity<string>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }
        
        //public virtual ICollection<AspNetUser> AspNetUsers{ get; set; }
    }
}

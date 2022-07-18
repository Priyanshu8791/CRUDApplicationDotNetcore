using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Models
{
    public partial class Country5
    {
        public Country5()
        {
            Costomer5s = new HashSet<Costomer5>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Costomer5> Costomer5s { get; set; }
    }
}

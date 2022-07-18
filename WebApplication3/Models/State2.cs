using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Models
{
    public partial class State2
    {
        public State2()
        {
            Costomer5s = new HashSet<Costomer5>();
        }

        public int StateId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Costomer5> Costomer5s { get; set; }
    }
}

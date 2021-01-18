using System;
using System.Collections.Generic;

namespace Domain
{
    public class Region
    {
        public Region()
        {
            Territories = new HashSet<Territory>();
        }

        public Guid Id { get; set; }

        public string Description { get; set; }

        public ICollection<Territory> Territories { get; private set; }
    }
}

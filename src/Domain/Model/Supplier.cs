using System;
using System.Collections.Generic;

namespace Domain
{
    public class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string HomePage { get; set; }

        public Address Address { get; set; }

        public ICollection<Product> Products { get; private set; }
    }
}

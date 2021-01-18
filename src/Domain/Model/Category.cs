﻿using System;
using System.Collections.Generic;

namespace Domain
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public byte[] Picture { get; set; }

        public ICollection<Product> Products { get; private set; }
    }
}

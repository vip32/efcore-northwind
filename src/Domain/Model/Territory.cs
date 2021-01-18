using System;
using System.Collections.Generic;

namespace Domain
{
    public class Territory
    {
        public Territory()
        {
            Employees = new HashSet<Employee>();
        }

        public Guid Id { get; set; }

        public string Description { get; set; }

        public Region Region { get; set; }

        public ICollection<Employee> Employees { get; private set; }
    }
}

using System;
using System.Collections.Generic;

namespace Domain
{
    public class Employee
    {
        public Employee()
        {
            Territories = new HashSet<Territory>();
            DirectReports = new HashSet<Employee>();
            //Orders = new HashSet<Order>();
        }

        public Guid Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Title { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }

        public string HomePhone { get; set; }

        public byte[] Photo { get; set; }

        public string Notes { get; set; }

        public Guid? ReportsTo { get; set; }

        public string PhotoPath { get; set; }

        public Address HomeAddress { get; set; }

        public Employee Manager { get; set; }

        public ICollection<Territory> Territories { get; private set; }

        public ICollection<Employee> DirectReports { get; private set; }

        //public ICollection<Order> Orders { get; private set; }

        public ICollection<Region> Regions { get; private set; }
    }
}

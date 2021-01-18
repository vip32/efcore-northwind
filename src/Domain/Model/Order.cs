using System;
using System.Collections.Generic;

namespace Domain
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public Guid Id { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        public Guid? ShipVia { get; set; }

        public decimal? Freight { get; set; }

        public Address Address { get; set; }

        public Customer Customer { get; set; }

        public Employee Employee { get; set; }

        public Shipper Shipper { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; private set; }
    }
}

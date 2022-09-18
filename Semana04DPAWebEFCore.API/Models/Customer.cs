﻿using System;
using System.Collections.Generic;

namespace Semana04DPAWebEFCore.API.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Models
{
    public class Admin
    {
        public int AdminID { get; set; }// PK
        public string Username { get; set; } // Username for the admin
        public string Password { get; set; } // Encrypted password

        // List of Coupons 
        public List<Coupon> Coupons { get; set; } = new List<Coupon>();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.Models;
using Microsoft.EntityFrameworkCore;

namespace back.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {

        }

        public DbSet<Admin> Admin { get; set; }

        public DbSet<Coupon> Coupon { get; set; }

        public DbSet<CouponUsage> CouponUsage { get; set; }

    }
}
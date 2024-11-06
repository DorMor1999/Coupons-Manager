using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Models
{
    public class CouponUsage
    {
        public int UsageID { get; set; }// PK
        public int CouponID { get; set; }// FK to Cupon
        public DateTime UsageDate { get; set; }// Date when the coupon was used  
        public decimal PriceBefore { get; set; }// The original price of the order before the discount
        public decimal DiscountAmount { get; set; }// The discount amount applied to the order

        public Coupon Coupon { get; set; } // refrence to this Coupon
    }
}
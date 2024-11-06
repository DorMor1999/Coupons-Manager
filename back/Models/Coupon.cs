using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Models
{
    public class Coupon
    {
        public int CouponID { get; set; } //PK
        public string Code { get; set; } // The coupon code
        public string Description { get; set; } // Description of the coupon, only visible to Admin
        public decimal DiscountValue { get; set; } // Discount value (either percentage or amount)
        public bool IsPercentage { get; set; } // True if the discount is in percentage, otherwise in fixed amount
        public DateTime ExpiryDate { get; set; } // Expiry date of the coupon, nullable
        public bool IsStackable { get; set; } // Whether the coupon can be used with others coupons
        public int MaxUses { get; set; } // Maximum number of times the coupon can be used
        public DateTime CreatedDate { get; set; } // Date and time when the coupon was created


        public int AdminID { get; set; } //FK to Admin
        public Admin Admin { get; set; } // refrence to the created Admin


        // List of CouponUsages 
        public List<CouponUsage> CouponUsages { get; set; } = new List<CouponUsage>();
    }
}
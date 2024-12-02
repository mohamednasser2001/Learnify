using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [PrimaryKey(nameof(UserId), nameof(WishlistId))]
    public class UserWishlist
    {
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        [ValidateNever]
        public User User { get; set; }

        [ValidateNever]
        public int WishlistId { get; set; }
        [ForeignKey(nameof(WishlistId))]
        [ValidateNever]
        public Wishlist Wishlist { get; set; }
    }
}

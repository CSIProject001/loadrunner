﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShoppingCart.cs" company="CandiSyrup">
//   VirtualHeights LLC
// </copyright>
// <summary>
//   The shopping cart.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CS.Models.CandiSyrupViewModels
{
    /// <summary>
    /// The shopping cart.
    /// </summary>
    public class ShoppingCart 
    {
        public int CartId { get; set; }

        public int ProductId { get; set; }

        public decimal Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Price { get; set; }

        public string Coupon { get; set; }

        public decimal DiscountPrice { get; set; }
    }
}
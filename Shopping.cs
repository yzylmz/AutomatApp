using System;
using System.Collections.Generic;
using CoreConsoleExample.Model;

namespace CoreConsoleExample
{
    public class Shopping
    {
        private List<Campaign> campains;
        public List<ShoppingCartProduct> shoppingCartProducts { get; set; }
        public decimal userBalance { get; set; }
        public decimal totalPrice { get; set; }
        public decimal campaignTotalPrice { get; set; }

        public Shopping(List<Campaign> _campains, int _userBalance)
        {
            shoppingCartProducts = new List<ShoppingCartProduct>();
            campains = _campains;
            userBalance = _userBalance;
        }

        public Boolean AddProductToCart(ShoppingCartProduct shoppingCartProduct)
        {
            if (userBalance >= shoppingCartProduct.product.price)
            {
                totalPrice += shoppingCartProduct.product.price;
                userBalance -= shoppingCartProduct.product.price;
                shoppingCartProducts.Add(shoppingCartProduct);
                if (userBalance == 0)
                {
                    return true;
                }
                return false;
            }
            return true;
        }
    }
}
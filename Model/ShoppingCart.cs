using System.Collections.Generic;

namespace CoreConsoleExample.Model
{
    public class ShoppingCart
    {
        private List<Campaign> Campains;

        public List<ShoppingCartProduct> ShoppingCartProducts { get; set; }

        public decimal TotalPrice { get; set; }

        public ShoppingCart(List<Campaign> _campains)
        {
            ShoppingCartProducts = new List<ShoppingCartProduct>();
            Campains = _campains;
        }

        public void CalculateTotalPrice()
        {
        }

    }
}
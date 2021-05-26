using System.Collections.Generic;

namespace CoreConsoleExample.Model
{
    public class ShoppingCart
    {
        private IEnumerable<Campaign> Campains;

        public IEnumerable<ShoppingCartProduct> ShoppingCartProducts { get; set; }

        public decimal TotalPrice { get; set; }

        public ShoppingCart(IEnumerable<Campaign> _campains)
        {
            ShoppingCartProducts = new List<ShoppingCartProduct>();
            Campains = _campains;
        }

        public void CalculatePrice()
        {
        }

    }
}
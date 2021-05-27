using System;
using System.Collections.Generic;
using System.Linq;
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
            // CalculatePrice(shoppingCartProduct);

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

        private void CalculatePrice(ShoppingCartProduct shoppingCartProduct)
        {
            List<int> _list = new List<int>();
            List<IEnumerable<int>> resList = new List<IEnumerable<int>>();

            foreach (var item in shoppingCartProducts)
            {
                _list.Add(item.product.id);
            }

            var secondaryCombs = GetKCombs(_list, 2);
            foreach (var item in secondaryCombs)
            {
                resList.Add(item);
            }

            var tritaCombs = GetKCombs(_list, 3);
            foreach (var item in tritaCombs)
            {
                resList.Add(item);
            }
        }
        
        static IEnumerable<IEnumerable<T>> GetKCombs<T>(IEnumerable<T> list, int length) where T : IComparable
        {
            if (length == 1) return list.Select(t => new T[] { t });
            return GetKCombs(list, length - 1)
                .SelectMany(t => list.Where(o => o.CompareTo(t.Last()) > 0),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }
    }
}
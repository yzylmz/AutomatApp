using System;
using System.Collections.Generic;
using CoreConsoleExample;
using CoreConsoleExample.Model;

namespace automatApp
{
    class Program
    {
        static int tableWidth = 73;
        private static SeedData SeedData;
        private static ShoppingCart ShoppingCart;
        static void Main(string[] args)
        {
            SeedData = new SeedData();
            ShoppingCart = new ShoppingCart(SeedData.Campaigns);

            Console.Clear();
            do
            {
                int selectedProductId = ShowProducts();
                AddProductToCart(selectedProductId);
            } while (true);
        }

        static void AddProductToCart(int productId)
        {
            ShoppingCartProduct shoppingCartProduct = new ShoppingCartProduct
            {
                Product = SeedData.Products.Find(p => p.Id == productId)
            };
            ShoppingCart.ShoppingCartProducts.Add(shoppingCartProduct);
            ShoppingCart.CalculateTotalPrice();
            ShowShoppingCart();
        }

        static void ShowShoppingCart()
        {
            PrintLine();
            PrintRow("SHOPPING CART");
            PrintLine();
            PrintRow("Id", "Name", "Price", "Campaign Price");
            PrintLine();
            foreach (var shoppingCartProduct in ShoppingCart.ShoppingCartProducts)
            {
                PrintRow(shoppingCartProduct.Product.Id.ToString(), shoppingCartProduct.Product.Name.ToString(), shoppingCartProduct.Product.Price.ToString(), shoppingCartProduct.CampaignPrice.ToString());
            }
            PrintLine();
        }

        static int ShowProducts()
        {
            PrintLine();
            PrintRow("AUTOMAT PRODUCTS");
            PrintLine();
            PrintRow("Id", "Name", "Price");
            PrintLine();
            foreach (var product in SeedData.Products)
            {
                PrintRow(product.Id.ToString(), product.Name.ToString(), product.Price.ToString());
            }
            PrintLine();
            Console.WriteLine("Enter product id");
            var productId = Console.ReadLine();
            return Convert.ToInt32(productId);
        }

        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }


    }
}

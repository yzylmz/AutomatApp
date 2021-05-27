using System;
using CoreConsoleExample.Model;

namespace CoreConsoleExample
{
    public class AutomatUI
    {
        private static int tableWidth = 73;
        private static SeedData seedData;
        private static Shopping shopping;

        public AutomatUI()
        {
            Console.Clear();
            seedData = new SeedData();
            int userBalance = GetUserBalance();
            Console.WriteLine("User balance : " + userBalance);
            Console.WriteLine("Enter 'f' for finish shopping");
            shopping = new Shopping(seedData.campaigns, userBalance);
            do
            {
                string selected = ShowProducts();
                if (selected == "f")
                {
                    break;
                }

                Boolean isInsufficientBalance = AddProductToCart(Convert.ToInt32(selected));
                if (isInsufficientBalance == true)
                {
                    Console.WriteLine("Insufficient balance");
                    break;
                }

                ShowShoppingCart();
                ShowShoppingPrices();
            } while (true);

            CreateReport();
        }

        private void CreateReport()
        {

        }

        static Boolean AddProductToCart(int productId)
        {
            ShoppingCartProduct shoppingCartProduct = new ShoppingCartProduct
            {
                product = seedData.products.Find(p => p.id == productId)
            };
            return shopping.AddProductToCart(shoppingCartProduct);
        }

        static void ShowShoppingCart()
        {
            Console.WriteLine();
            PrintLine();
            PrintRow("SHOPPING CART");
            PrintLine();
            PrintRow("Id", "Name", "Price", "Campaign Price");
            PrintLine();
            foreach (var shoppingCartProduct in shopping.shoppingCartProducts)
            {
                PrintRow(shoppingCartProduct.product.id.ToString(), shoppingCartProduct.product.name.ToString(), shoppingCartProduct.product.price.ToString(), shoppingCartProduct.campaignPrice.ToString());
            }
            PrintLine();
            Console.WriteLine();
        }

        static void ShowShoppingPrices()
        {
            Console.WriteLine();
            PrintLine();
            PrintRow("SHOPPING PRICES");
            PrintLine();
            PrintRow("*", "Balance", "Total Price", "Campaign Price");
            PrintLine();
            PrintRow("*", shopping.userBalance.ToString(), shopping.totalPrice.ToString(), shopping.campaignTotalPrice.ToString());
            PrintLine();
            Console.WriteLine();
        }

        static string ShowProducts()
        {
            Console.WriteLine();
            PrintLine();
            PrintRow("AUTOMAT PRODUCTS");
            PrintLine();
            PrintRow("Id", "Name", "Price");
            PrintLine();
            foreach (var product in seedData.products)
            {
                PrintRow(product.id.ToString(), product.name.ToString(), product.price.ToString());
            }
            PrintLine();
            Console.WriteLine("Enter product id");
            return Console.ReadLine();
        }
        static int GetUserBalance()
        {
            Console.WriteLine("Please enter balance");
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
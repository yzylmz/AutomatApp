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
            // Ürün ve kampanya listesi oluşturuluyor
            seedData = new SeedData();

            // Kullanıcıdan bakiye bilgisi alınıyor
            int userBalance = GetUserBalance();
            Console.WriteLine("User balance : " + userBalance);
            Console.WriteLine("Enter 'f' for finish shopping");

            // Shopping class i oluşturuluyor
            shopping = new Shopping(seedData.campaigns, userBalance);

            // Bakiye 0 olana kadar veya alışveriş sonlandırılana kadar çalışır
            do
            {
                // Ürünler listeleniyor
                string selected = ShowProducts();

                // Kullanıcı 'f' key i girerse alışveriş sonlandırılıyor
                if (selected == "f")
                {
                    break;
                }

                // Kullanıcının seçtiği ürün sepete ekleniyor
                Boolean isInsufficientBalance = AddProductToCart(Convert.ToInt32(selected));

                // Her eklenen üründe bakiyenin yetersiz olup olmadığı kontrol ediliyor
                if (isInsufficientBalance == true)
                {
                    Console.WriteLine("Insufficient balance");
                    break;
                }

                // Alışveriş sepeti listeleniyor
                ShowShoppingCart();

                // Alışveriş toplam ve kampanyalı tutarı ile birlikte bakiye listeleniyor
                ShowShoppingPrices();
            } while (true);

            // Alışveriş sonlandıktan sonra alışveriş raporu oluşturuluyor
            CreateReport();
        }

        // Sepete yeni bir ürün ekler
        static Boolean AddProductToCart(int productId)
        {
            ShoppingCartProduct shoppingCartProduct = new ShoppingCartProduct
            {
                product = seedData.products.Find(p => p.id == productId)
            };
            return shopping.AddProductToCart(shoppingCartProduct);
        }

        // Sepete eklenen ürünleri normal ve kampanyalı fiyatları ile birlikte listeler
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

        // Alışveriş toplam ve kampanyalı tutarı ile birlikte bakiyeyi listeler
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

        // Ürünleri listeler
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

        // Kullanıcıdan bakiye bilgisini alır
        static int GetUserBalance()
        {
            Console.WriteLine("Please enter balance");
            var productId = Console.ReadLine();
            return Convert.ToInt32(productId);
        }

        // Alışveriş raporunu oluşturur 
        private void CreateReport()
        {
            ShowShoppingCart();
            ShowShoppingPrices();
        }

        // Console ekranı tablo şekillendirmelerini oluştururlar
        #region uiComponents
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
        #endregion

    }
}
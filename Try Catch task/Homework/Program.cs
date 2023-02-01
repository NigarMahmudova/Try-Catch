using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Store store1 = new Store();
            do
            {
                Console.WriteLine("1. Product elave et.");
                Console.WriteLine("2. Butun product-lara bax.");
                Console.WriteLine("3. Verilmis nomreli producta bax.");
                Console.WriteLine("0. Menu-dan cixis.");
                Console.Write("Secim edin --> ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        input = "-1";
                        Console.WriteLine("Eminsiniz mi? Yes/No");
                        if (Console.ReadLine() == "Yes")
                        {
                            input = "0";
                        }
                        break;
                    case "1":
                        Console.WriteLine("Category daxil edin...");
                        string category = Console.ReadLine();

                        Console.WriteLine("Price daxil edin...");
                        double price = Convert.ToDouble(Console.ReadLine());

                        Product product = new Product(category, price);
                        if (!store1.HasProductByNo(product.No))
                        {
                            store1.AddProduct(product);
                        }
                        break;
                    case "2":
                        store1.ShowProducts();
                        break;
                    case "3":
                        try
                        {
                            Console.WriteLine("No daxil edin...");
                            int no = Convert.ToInt32(Console.ReadLine());
                            Product pr = store1.GetProductByNo(no);
                            Console.WriteLine($"Category: {pr.Category} - Price: {pr.Price}"); 
                        }
                        catch (ProductNotFoundException)
                        {
                            Console.WriteLine("Xeta bas verdi.");
                        }
                        break;
                    default:
                        Console.WriteLine("Yanlis secim etdiniz, yeniden secim edin.");
                        break;
                }

            } while (input != "0") ;
            
        }
    }
}

namespace Metods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 29;
            product1.Name = "IPhone 13";
            product1.Price = 1099.90;
            product1.Description = "High quality mobile phone";

            Product product2 = new Product();
            product2.Id = 46;
            product2.Name = "Samsung S20";
            product2.Price = 1299.90;
            product2.Description = "The best android phone";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine("Id:{0}\nProduct Name: {1}\nPrice: {2}\nDescription: {3}",
                    product.Id, product.Name, product.Price, product.Description);
                Console.WriteLine("******************************\n");
            }

            Console.WriteLine("\n\n");

            ChartManager chartManager = new ChartManager();

            chartManager.Add(product2);
            chartManager.Add(product1);

        }
    }
}
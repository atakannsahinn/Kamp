namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "atakan", "engin", "ilker" };
            //isimler[3] = "ilayda"; // arrayler sonradan değiştirilemez o yüzden bu satırda hata alırız.

            // Bu yüzden collectionslar yani listeleri kullanırız.

            List<string> isimler2 = new List<string>(); // boş liste

            List<string> isimler3 = new List<string> {"atakan", "engin", "ilker"};
            Console.WriteLine(isimler3[0]);
            Console.WriteLine(isimler3[1]);
            Console.WriteLine(isimler3[2]);
            
            isimler3.Add("ilayda");

            Console.WriteLine("\n\n");

            Console.WriteLine(isimler3[3]);
            Console.WriteLine(isimler3[0]);



        }
    }
}
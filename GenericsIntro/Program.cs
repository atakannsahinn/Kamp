namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("a");
            names.Add("b");
            Console.WriteLine(names);
        }
    }
}
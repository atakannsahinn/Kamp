namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager bireyselKrediManager = new BireyselKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(tasitKrediManager);
            basvuruManager.BasvuruYap(konutKrediManager);
            basvuruManager.BasvuruYap(bireyselKrediManager);

            Console.WriteLine("*******************************");


            List<IKrediManager> krediler = new List<IKrediManager>() { bireyselKrediManager, tasitKrediManager};

            basvuruManager.BasvuruYapListe(krediler);

            Console.WriteLine("*****************************");
            
            basvuruManager.BasvuruYapListe(konutKrediManager, bireyselKrediManager);
        }
    }
}
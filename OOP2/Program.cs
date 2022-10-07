namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Atakan Şahin
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.IdentityNo = "12345678901";
            customer1.Name = "Atakan";
            customer1.LastName = "Şahin";
            customer1.CustomerNo = "123456";

            //Kodlama.io
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "9876564";
            customer2.FirmName = "Kodlama.io";
            customer2.TaxNo = "147852369";


            // ***important***
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer> (); 

            Customer customer1 = new Customer();
            customer1.CustomerName = "Atakan";
            customer1.CustomerId = 1;
            customer1.CustomerNo = "1258";
            customer1.CustomerBalance = 12580.90;

            Customer customer2 = new Customer();
            customer2.CustomerName = "İlayda";
            customer2.CustomerId = 2;
            customer2.CustomerNo = "2688";
            customer2.CustomerBalance = 569;

            Customer customer3 = new Customer();
            customer3.CustomerName = "Hasan";
            customer3.CustomerId = 3;
            customer3.CustomerNo = "6518";
            customer3.CustomerBalance = 3689.98;

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1, customers);
            customerManager.AddCustomer(customer2, customers);
            customerManager.AddCustomer(customer3, customers);

            customerManager.DeleteCustomer(customer2, customers);

            customerManager.DepositMoney(customer1, 1200);

            customerManager.WithdrawMoney(customer3, 650);
            
            customerManager.ShowCustomers(customers);

        }
    }
}
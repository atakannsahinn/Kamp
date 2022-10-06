using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {
        
        public void AddCustomer(Customer customer, List<Customer> customers)
        {
            customers.Add(customer);
        }

        public void DeleteCustomer(Customer customer, List<Customer> customers) 
        {
            customers.Remove(customer);
        }

        public void ShowCustomers(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer Id : " + customer.CustomerId);
                Console.WriteLine("Customer Name : " + customer.CustomerName);
                Console.WriteLine("Customer No : " + customer.CustomerNo);
                Console.WriteLine("Customer Balance : " + customer.CustomerBalance);
                Console.WriteLine("*********************************");

            }
        }

        public void DepositMoney(Customer customer, double money) 
        {
            customer.CustomerBalance = customer.CustomerBalance + money;
        }

        public void WithdrawMoney(Customer customer, double money)
        {
            customer.CustomerBalance = customer.CustomerBalance - money;
        }
    }
}

using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer2 = new Customer();
            customer2.CityId = 34;
            customer2.CustomerFullName = "İrfan Akarsu";
            customer2.PhoneNumber = "555555555";
            
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(customer2);
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(
                    "Customers Name: " + customer.CustomerFullName 
                    +"\nCustomers City: " + customer.CityId
                    + "\nCustomers Phone: " + customer.PhoneNumber);
            }
        }
    }
}

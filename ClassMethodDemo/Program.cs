using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // First array element
            Customer customer1 = new Customer();
            customer1.Name = "Ali";
            customer1.Surname = "Veli";
            customer1.Age = 26;
            customer1.Job = "Finance";
            customer1.Adress = "İstanbul";
            // Second array element
            Customer customer2 = new Customer();
            customer2.Name = "İsmail";
            customer2.Surname = "Kaya";
            customer2.Age = 42;
            customer2.Job = "Sales";
            customer2.Adress = "Ankara";
            
            
            // Array
            Customer[] customers = new Customer[]
            {
                customer1,
                customer2
            };
            
        }
    }
}

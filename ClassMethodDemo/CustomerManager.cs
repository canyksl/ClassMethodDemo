using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            //Codes for the add method will be written here
            Console.WriteLine("Müşteri Eklendi:  "+customer.Name);
        }

        public void Update(Customer customer)
        {
            //Codes for the update method will be written here
            Console.WriteLine("Müşteri Güncellendi:  "+customer.Name);
        }

        public void Delete(Customer customer)
        {
            //Codes for the delete method will be written here
            Console.WriteLine("Müşteri Silindi!");
        }

        public void List(Customer[] customers)
        {
            //List For Customers Array
            Console.WriteLine("Customers");
            Console.WriteLine("-------------------------");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine(customer.Age);
                Console.WriteLine(customer.Job);
                Console.WriteLine(customer.Adress);
                Console.WriteLine("*************************");
            }

        }
    }
}

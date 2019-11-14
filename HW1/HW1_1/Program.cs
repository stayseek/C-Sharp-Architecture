using System;

namespace HW1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Тестовый", new DefaultIdGenerator());
            Store store = new Store(new DefaultIdGenerator());
            Console.WriteLine("Customers Id: {0}\nCustomers Description: {1}\nStores Id: {2}", 
                customer.Id.ToString(),
                customer.Description,
                store.Id.ToString());
            Console.ReadLine();
        }
    }
}

using System;

namespace CustomerChasing
{
    class Program
    {
        static void Main(string[] args)
        {
            Costumersİnfo customer1 = new Costumersİnfo()
            {
                ID = 1,
                NAME = "Costomer1",
                SURNAME = "Costumer1s"
            };
            Costumersİnfo customer2 = new Costumersİnfo()
            {
                ID = 2,
                NAME = "Costumer2",
                SURNAME = "Costumer2s"
            };
            Costumersİnfo customer3 = new Costumersİnfo()
            {
                ID = 3,
                NAME = "Costumer3",
                SURNAME = "Costumer3s"
            };

            CostumerManagement manager = new CostumerManagement();
            Costumersİnfo[] customer = new Costumersİnfo[] { customer1, customer2, customer3 };

            Console.WriteLine("ADDED");
            for (int i = 0; i < customer.Length; i++)
            {
                manager.Add(customer[i]);
            }

            Console.WriteLine("DELETED");

            for (int i = 0; i < customer.Length; i++)
            {
                manager.Delete(customer[i]);
            }
            Console.WriteLine("LİSTED");
            manager.List(customer);

            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerChasing
{
    class CostumerManagement
    {
        public void Add(Costumersİnfo customer)
        {
            Console.WriteLine("Customer ID : " + customer.ID);
            Console.WriteLine("Customer Name : " + customer.NAME);
            Console.WriteLine("Customer Surname : " + customer.SURNAME);
            Console.WriteLine("Customer is Added");
        }

        public void Delete(Costumersİnfo customer)
        {
            Console.WriteLine("Customer ID : " + customer.ID);
            Console.WriteLine("Customer Name : " + customer.NAME);
            Console.WriteLine("Customer Surname : " + customer.SURNAME);
            Console.WriteLine("Customer is Deleted");
        }
        public void List(Costumersİnfo[] customer)
        {


            foreach (Costumersİnfo customers in customer)
            {

                Console.WriteLine("Customer ID : " + customers.ID);
                Console.WriteLine("Customer Name : " + customers.NAME);
                Console.WriteLine("Customer Surname : " + customers.SURNAME);

            }
        }
    }
}

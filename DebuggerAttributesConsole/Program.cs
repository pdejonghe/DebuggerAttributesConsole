using System;

namespace DebuggerAttributesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Product soap = new Product
            {
                Category = "A",
                Code = "SOAP-56",
                Name = "Sunlight",
                Price = 5.3M,
            };

            var colruyt = new Customer
            {
                CustomerId = 1,
                Name = "Colruyt",
                City = "Halle",
                Code = "COL",
                DateOfFirstOrder = new DateTime(2016, 10, 2),
            };

            colruyt.PlaceOrder(soap, 5);
            colruyt.PlaceOrder(soap, 7);
            colruyt.PlaceOrder(soap, 3);

            Console.ReadKey();
        }
    }
}

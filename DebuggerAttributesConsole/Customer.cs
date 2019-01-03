using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DebuggerAttributesConsole
{
    //Customer will be displayed like a CustomerDebuggingView in Debugging windows ...
    [DebuggerTypeProxy(typeof(CustomerDebuggingView))]
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime DateOfFirstOrder { get; set; }
        public string City { get; set; }

        public ICollection<CustomerOrder> Orders { get; } = new List<CustomerOrder>();

        public void PlaceOrder(string productCode, int quantity, decimal productPrice)
        {
            Orders.Add(new CustomerOrder(productCode, quantity, productPrice));
        }

        public void PlaceOrder(Product product, int quantity)
        {
            this.PlaceOrder(product.Code, quantity, product.Price);
        }
    }
}

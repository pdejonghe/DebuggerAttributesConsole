using System;
using System.Collections.Generic;
using System.Text;

namespace DebuggerAttributesConsole
{
    public class CustomerOrder
    {
        public Guid CustomerOrderId { get; set; }

        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public decimal ProductPrice { get; set; }

        public CustomerOrder(string code, int quantity, decimal price)
        {
            this.ProductCode = code;
            this.Quantity = quantity;
            this.ProductPrice = price;
        }

        public decimal CalculateOrderTotal()
        {
            return Quantity * ProductPrice;
        }
    }
}

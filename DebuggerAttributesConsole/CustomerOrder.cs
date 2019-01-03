using System;
using System.Diagnostics;

namespace DebuggerAttributesConsole
{
    //A CustomerOrder will displayed as one line of text in Debugging windows ...
    [DebuggerDisplay("{Quantity} * {ProductCode} at ${ProductPrice} = {CalculateOrderTotal()}")]
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

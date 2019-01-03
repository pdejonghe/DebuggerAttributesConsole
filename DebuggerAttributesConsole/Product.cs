using System;
using System.Diagnostics;

namespace DebuggerAttributesConsole
{
    public class Product
    {
        //ProductId will not be visible in Debugging windows ...
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public Guid ProductId { get; }

        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        //When debugging, the constructor call will be skipped ...
        [DebuggerStepThrough]
        public Product()
        {
            ProductId = Guid.NewGuid();
        }
    }
}

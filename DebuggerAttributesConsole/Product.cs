using System;
using System.Collections.Generic;
using System.Text;

namespace DebuggerAttributesConsole
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}

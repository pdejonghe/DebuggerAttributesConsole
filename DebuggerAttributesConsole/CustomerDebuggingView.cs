using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DebuggerAttributesConsole
{
    /// <summary>
    /// Custom display of Customer objects in Debugging windows.
    /// </summary>
    public class CustomerDebuggingView
    {
        private Customer Customer { get; }

        public string CustomerName => $"{Customer.Name} - {Customer.Code}";
        public decimal TurnOver => Customer.Orders.Sum(o => o.CalculateOrderTotal());

        /// <summary>
        /// DebuggerBrowsableState.Never: do not display
        /// DebuggerBrowsableState.Collapsed: show Orders collapsed
        /// DebuggerBrowsableState.RootHidden: show individual orders without Orders header.
        ///     This is actually showing the Orders expanded, without the Orders header.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public List<CustomerOrder> Orders => Customer.Orders.ToList();

        public CustomerDebuggingView(Customer customer) => this.Customer = customer;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    public class ConcreteCommand
    {
        public class AddCommand: OrderCommand
        {
            public override void Execute (List<MenuItem> currentItems, MenuItem newItem)
            {
                currentItems.Add(newItem);
            }
        }

        public class RemoveCommand: OrderCommand
        {
            public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
            {
                currentItems.Remove(currentItems.Where(x => x.Name == newItem.Name).First());
            }
        }

        public class ModifyCommand : OrderCommand
        {
            public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
            {
                var item = currentItems.Where(x => x.Name == newItem.Name).First();
                item.Price = newItem.Price;
                item.Amount = newItem.Amount;
            }
        }
    }
}

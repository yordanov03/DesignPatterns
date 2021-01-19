using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    /// <summary>
    /// The aggregate interface
    /// </summary>
    interface ICandyCollection
    {
        JellyBeanIterator CreateIterator();
    }

    /// <summary>
    /// The ConcreteAggregate class
    /// </summary>
    class JellyBeanCollection : ICandyCollection
    {
        private ArrayList _items = new ArrayList();

        public JellyBeanIterator CreateIterator()
        {
            return new JellyBeanIterator(this);
        }

        // Gets jelly bean count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}

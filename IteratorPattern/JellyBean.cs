using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    class JellyBean
    {
        private string _flavor;

        // Constructor
        public JellyBean(string flavor)
        {
            this._flavor = flavor;
        }


        public string Flavor
        {
            get { return _flavor; }
        }
    }
}

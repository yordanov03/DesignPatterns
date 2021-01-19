﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    /// <summary>
    /// The 'Iterator' interface
    /// </summary>
    interface IJellyBeanIterator
    {
        JellyBean First();
        JellyBean Next();
        bool IsDone { get; }
        JellyBean CurrentBean { get; }
    }

    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    class JellyBeanIterator : IJellyBeanIterator
    {
        private JellyBeanCollection _jellyBeans;
        private int _current = 0;
        private int _step = 1;

        // Constructor
        public JellyBeanIterator(JellyBeanCollection beans)
        {
            this._jellyBeans = beans;
        }

        // Gets first jelly bean
        public JellyBean First()
        {
            _current = 0;
            return _jellyBeans[_current] as JellyBean;
        }

        // Gets next jelly bean
        public JellyBean Next()
        {
            _current += _step;
            if (!IsDone)
                return _jellyBeans[_current] as JellyBean;
            else
                return null;
        }

        // Gets current iterator candy
        public JellyBean CurrentBean
        {
            get { return _jellyBeans[_current] as JellyBean; }
        }

        // Gets whether iteration is complete
        public bool IsDone
        {
            get { return _current >= _jellyBeans.Count; }
        }
    }
}

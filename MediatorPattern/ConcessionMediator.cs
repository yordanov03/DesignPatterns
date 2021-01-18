using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    /// <summary>
    /// The Concrete Mediator class, which implement the send message method and keep track of all participants in the conversation.
    /// </summary>
    class ConcessionMediator : IMediator
    {
        private NorthConcessionStand _northConcessions;
        private SouthConcessionStand _southConcessions;

        public NorthConcessionStand NorthConcessions
        {
            set { _northConcessions = value; }
        }

        public SouthConcessionStand SouthConcessions
        {
            set { _southConcessions = value; }
        }

        public void SendMessage(string message, ConcessionStand concessionStand)
        {
            if(concessionStand == _northConcessions)
            {
                _southConcessions.Notify(message);
            }
            else
            {
                _northConcessions.Notify(message);
            }
        }
    }
}

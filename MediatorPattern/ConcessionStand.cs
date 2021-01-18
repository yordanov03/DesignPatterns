using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    /// <summary>
    /// The Colleague abstract class, representing 
    /// an entity involved in the conversation 
    /// which should receive messages.
    /// </summary>
    abstract class ConcessionStand
    {
        protected IMediator mediator;

        public ConcessionStand(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}

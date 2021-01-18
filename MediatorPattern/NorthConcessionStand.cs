using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    /// <summary>
    /// A Concrete Colleague class
    /// </summary>
    class NorthConcessionStand: ConcessionStand
    {
        public NorthConcessionStand(IMediator mediator) : base(mediator) { }

        public void Send(string message)
        {
            Console.WriteLine("North Concession Stand sends a message: " + message);
            mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("North Concession Stand gets a message: " + message);
        }

    }
}

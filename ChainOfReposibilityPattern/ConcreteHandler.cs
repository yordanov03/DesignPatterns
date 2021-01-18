using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfReposibilityPattern
{
    public class ConcreteHandler
    {
       internal class HeadChef: Approver
        {
            public override void ProcessRequest(PurchaseOrder purchase)
            {
                if (purchase.Price<1000)
                {
                    Console.WriteLine("{0} approved purchase request #{1}",
                this.GetType().Name, purchase.RequestNumber);
                }

                else if (Supervisor != null)
                {
                    Supervisor.ProcessRequest(purchase);
                }
            }
        }

        internal class PurchasingManager : Approver
        {
            public override void ProcessRequest(PurchaseOrder purchase)
            {
                if (purchase.Price < 2500)
                {
                    Console.WriteLine("{0} approved purchase request #{1}",
                        this.GetType().Name, purchase.RequestNumber);
                }
                else if (Supervisor != null)
                {
                    Supervisor.ProcessRequest(purchase);
                }
            }
        }

        internal class GeneralManager : Approver
        {
            public override void ProcessRequest(PurchaseOrder purchase)
            {
                if (purchase.Price < 10000)
                {
                    Console.WriteLine("{0} approved purchase request #{1}",
                        this.GetType().Name, purchase.RequestNumber);
                }
                else
                {
                    Console.WriteLine(
                        "Purchase request #{0} requires an executive meeting!",
                        purchase.RequestNumber);
                }
            }
        }
    }
}

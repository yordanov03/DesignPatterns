using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class Rare : Doneness
    {
        public Rare(Doneness state) : this(state.CurrentTemp, state.Steak) { }

        public Rare(double currentTemp, Steak steak)
        {
            this.currentTemp = currentTemp;
            this.steak = steak;
            canEat = true; //We can now eat the steak
            Initialize();
        }

        private void Initialize()
        {
            lowerTemp = 130;
            upperTemp = 139.999999999999;
            canEat = true;
        }

        public override void AddTemp(double temp)
        {
            currentTemp += temp;
            DonenessCheck();
        }

        public override void RemoveTemp(double temp)
        {
            currentTemp -= temp;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (currentTemp < lowerTemp)
            {
                steak.State = new Uncooked(this);
            }
            else if (currentTemp > upperTemp)
            {
                steak.State = new Medium(this);
            }
        }
    }
}

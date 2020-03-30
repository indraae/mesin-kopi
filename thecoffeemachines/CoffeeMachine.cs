using System;
using System.Collections.Generic;
using System.Text;

namespace thecoffeemachines
{
    class CoffeeMachine
    {
        private CoffeePowder coffePowder;
        private WaterGalon waterGalon;
        private Milk milk; 
        public CoffeeMachine(CoffeePowder powder, WaterGalon galon,Milk milk)
        {
            this.waterGalon = galon;
            this.coffePowder = powder;
            this.Milk = milk;

            public String makeEsspresso()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }

            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            return "Yey! your coffe is ready";
        }
        public String makecappucino()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }
            if (!this.coffePowderisAvailable())
            {
                return "Sorry, milk is empty";
            }
            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            this.milk.makeOneCup();
            return "Yey! your coffe is ready";
            public String checkAvailability()
        {
                return $"the water :{this.waterGalon.getVolume()} , the coffe powder: { this.coffePowder.getNetto()}, and the milk : {this.Milk.getVolume()}";

            }
    }
}

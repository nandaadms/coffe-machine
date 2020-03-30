using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeeMachine
{
    class CoffeeMachine
    {
        private CoffeePowder coffePowder;
            private WaterGalon waterGalon;

        public CoffeeMachine(CoffeePowder powder, WaterGalon galon)
        {
            this.waterGalon = galon;
            this.coffePowder = powder;
        }

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

        public String checkAvailability()
        {
            return $"the water :{this.waterGalon.getVolume()} and the coffe" +
                $"powder : {this.coffePowder.getNetto()}";
        }
    }
}

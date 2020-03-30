using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeMachine
{
    class CoffeMachine
    {
        private CoffePowder coffePowder;
        private WaterGalon waterGalon;
        private milk milk;

        public CoffeMachine(CoffePowder powder, WaterGalon galon, milk milk)
        {
            this.waterGalon = galon;
            this.coffePowder = powder;
            this.milk = milk;
        }

        public String makeEsspresso()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "sorry,the water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "sorry,the coffe is empty";
            }

        
            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            return "Yey! your coffe is ready";
        }

        public String MakeCappucino()
        { 
        if (!this.waterGalon.isAvailable())
            {
                return "sorry,the water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "sorry,the coffe is empty";
            }
            if(!this.milk.isAvailable())
            {
                return "sorry,the milk is empty";
            }


            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            this.milk.makeOneCup();
            return "Yey! your coffe is ready";
        }
    public String checkAvailability()
        {
            return $"the water:{this.waterGalon.getVolume()} and the powder :{this.coffePowder.getNetto()} and the milk : {this.milk.getVolume()}";
        }
    }
}


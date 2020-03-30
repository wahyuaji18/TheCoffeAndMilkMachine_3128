using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeMachine
{
    class WaterGalon
    {
        private int volume = 0;
        private int volumeOneCup =250;
        private int volumeoneCup = 150;

        public WaterGalon(int volume)
        {
            this.volume = volume;
        }

        public Boolean isAvailable()
        {
            return volume >= volumeOneCup;
        }

        public Boolean isavailable()
        {
            return volume >= volumeoneCup;
        }
        public void addWater(int volume)
        {
            this.volume += volume;
        }
        public int makeOneCup()
        {
            this.volume = this.volume - this.volumeOneCup;
            return volumeOneCup;
        }
        public int makeoneCup()
        {
            this.volume = this.volume - this.volumeoneCup;
            return volumeoneCup;
        }
        public int getVolume()
        {
            return this.volume;
        }
    }
}

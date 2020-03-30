using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeMachine
{
    class milk
    {
        private int volume = 0;
        private int volumeOneCup = 100;

        public milk(int volume)
        {
            this.volume = volume;
        }
        public Boolean isAvailable()
        {
            return this.volume >= this.volumeOneCup;
        }
        public void addMilk(int milk)
        {
            this.volume += volume;
        }
        public int makeOneCup()
        {
            this.volume = this.volume - this.volumeOneCup;
            return volumeOneCup;
        }
        public int getVolume()
        {
            return this.volume;
        }
    }
}


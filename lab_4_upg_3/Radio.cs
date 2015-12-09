using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_upg_3
{
    class Radio
    {

        //volym, av/på, samt frekvensinställning
        // utöka den med två konstruktors som initierar Radion

        bool powerOn;
        int volume;
        double frequency;

        public bool PowerOn
        {
            get
            {
                return powerOn;
            }

            set
            {
                powerOn = value;
            }
        }

        public int Volume
        {
            get
            {
                return volume;
            }

            set
            {
                if (value > 0 && value < 50)
                    volume = value;
                else throw new Exception("error: volume");
            }
        }

        public double Frequency
        {
            get
            {
                return frequency;
            }

            set
            {
                if (value > 0 && value < 150.0)
                    frequency = value;
                else throw new Exception("error : frequency");
            }
        }

        //Den ena konstruktorn ska vara default-konstruktorn, och den andra ska sätta volym och frekvens.
        // I båda fallen ska on/off sättas till off.
        public Radio()
        {
            //PowerOn = false;
            Volume = 23;
            Frequency = 105.6;

        }
        public Radio(int volume) : this()
        {
            Volume = volume;
            //Frequency = frequency;
        }
        public Radio(int volume, double frequency) : this(volume)
        {
            ///*Volume*/ = volume;
            Frequency = frequency;
        }

        public override string ToString()
        {
            return $"Power on: {powerOn}, Volume: {volume}, Frequency: {frequency}.";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Smart_TV
/// @author Jared Daniel
/// @author Stuart Walters
/// Class designed to extend the behavior of TV by adding power usage functionality. Class CANNOT be subclassed.
/// </summary>
namespace Lab08
{
    class Smart_TV:TV
    {
        private double powerUsage;

        public Smart_TV()
        {
            setType("Smart");
        }

        internal double getPowerUsage()
        {
            return powerUsage;
        }

        public void setPowerUsage(double power)
        {
            powerUsage = power;
        }

        override public void getInfo()
        {
            base.getInfo();
            Console.WriteLine("Power Usage: " + getPowerUsage());
        }

    }
}

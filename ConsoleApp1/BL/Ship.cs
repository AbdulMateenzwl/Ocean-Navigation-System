using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BL
{
    internal class Ship
    {
        public string name;
        public Angle X;
        public Angle Y;
        public Ship() { }

        public Ship(string name, Angle x, Angle y)
        {
            this.name = name;
            X = x;
            Y = y;
        }
        public void replace(Angle x, Angle y)
        {
            this.X=x;
            this.Y=y;
        }
        public void display_angle()
        {
            Console.WriteLine("Ship is at "+X.degree+"\u00b0"+X.minutes+"'"+X.direction+" and " + Y.degree + "\u00b0" + Y.minutes + "'" + Y.direction);
        }
        public void display_name()
        {
            Console.WriteLine("THe name of the ship is "+name+" .");
        }
    }
}

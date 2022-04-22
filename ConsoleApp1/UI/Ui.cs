using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.BL;
using ConsoleApp1.DL;

namespace ConsoleApp1.UI
{
    internal class Ui
    {
        public static Ship take_input()
        {
            Angle input = new Angle();
            Angle input2 = new Angle();
            Console.WriteLine("Enter the Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the X Degree : ");
            input.Degree =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the X Minute : ");
            input.Minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the X Direction : ");
            input.Direction = Console.ReadLine()[0];
            Console.WriteLine("Enter the Y Degree : ");
            input2.Degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y Minute : ");
            input2.Minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y Direction : ");
            input2.Direction = Console.ReadLine()[0];
            Ship ship = new Ship(name, input, input2);
            return ship;
        }
        public static void position()
        {
            Console.WriteLine("Enter the Name of ship : ");
            string name = Console.ReadLine();
            Ship output = Crud.index(name);
            if (output == null)
            {
                Console.WriteLine("There is no such Ship.");
            }
            else
            {
                output.display_angle();
            }
        }
        public static void serial_num()
        {
            Angle input = new Angle();
            Angle input2 = new Angle();
            Console.WriteLine("Enter the X Degree : ");
            input.Degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the X Minute : ");
            input.Minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the X Direction : ");
            input.Direction = Console.ReadLine()[0];
            Console.WriteLine("Enter the Y Degree : ");
            input2.Degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y Minute : ");
            input2.Minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y Direction : ");
            input2.Direction = Console.ReadLine()[0];
            Ship output = Crud.check_ship(input,input2);
            if(output != null)
            {
                output.display_name();
            }
            else
            {
                Console.WriteLine("There is no such ship.");
            }
        }
        public static void change_position()
        {
            Console.WriteLine("Enter the Name : ");
            string name = Console.ReadLine();
            Ship output = Crud.index(name);
            if (output == null)
            {
                Console.WriteLine("There is no such Ship.");
            }
            else
            {
                Angle input = new Angle();
                Angle input2 = new Angle();
                Console.WriteLine("Enter the X Degree : ");
                input.Degree = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the X Minute : ");
                input.Minutes = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the X Direction : ");
                input.Direction = Console.ReadLine()[0];
                Console.WriteLine("Enter the Y Degree : ");
                input2.Degree = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Y Minute : ");
                input2.Minutes = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Y Direction : ");
                input2.Direction = Console.ReadLine()[0];
                output.replace(input, input2);
                Console.WriteLine("Postion has been changed .");
            }
        }
        
    }
}

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
            input.degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the X Minute : ");
            input.minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the X Direction : ");
            input.direction = Console.ReadLine()[0];
            Console.WriteLine("Enter the Y Degree : ");
            input2.degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y Minute : ");
            input2.minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y Direction : ");
            input2.direction = Console.ReadLine()[0];
            Ship ship = new Ship(name, input, input2);
            return ship;
        }
        public static void position()
        {
            Console.WriteLine("Enter the Name of ship : ");
            string name = Console.ReadLine();
            int index = Crud.index(name);
            if (index == -1)
            {
                Console.WriteLine("There is no such Ship.");
            }
            else
            {
                Crud.ship_list[index].display_angle();
            }
        }
        public static void serial_num()
        {
            Angle input = new Angle();
            Angle input2 = new Angle();
            string name = "";
            Console.WriteLine("Enter the X Degree : ");
            input.degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the X Minute : ");
            input.minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the X Direction : ");
            input.direction = Console.ReadLine()[0];
            Console.WriteLine("Enter the Y Degree : ");
            input2.degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y Minute : ");
            input2.minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y Direction : ");
            input2.direction = Console.ReadLine()[0];
            Ship ship = new Ship(name, input, input2);
            int index = Crud.check_ship(ship);
            Crud.ship_list[index].display_name();
        }
        public static void change_position()
        {
            Console.WriteLine("Enter the Name : ");
            string name = Console.ReadLine();
            int index = Crud.index(name);
            if (index == -1)
            {
                Console.WriteLine("There is no such Ship.");
            }
            else
            {
                Angle input = new Angle();
                Angle input2 = new Angle();
                Console.WriteLine("Enter the X Degree : ");
                input.degree = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the X Minute : ");
                input.minutes = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the X Direction : ");
                input.direction = Console.ReadLine()[0];
                Console.WriteLine("Enter the Y Degree : ");
                input2.degree = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Y Minute : ");
                input2.minutes = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Y Direction : ");
                input2.direction = Console.ReadLine()[0];
                Crud.ship_list[index].replace(input, input2);
                Console.WriteLine("Postion has been changed .");
            }
        }
        public static char menu()
        {
            Console.WriteLine("1) Add Ship");
            Console.WriteLine("2) View Ship Position");
            Console.WriteLine("3) View Ship Serial Number");
            Console.WriteLine("4) Change Ship Position");
            Console.WriteLine("5) Exit");
            char ch = Console.ReadLine()[0];
            return ch;
        }
    }
}

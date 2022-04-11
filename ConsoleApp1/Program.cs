using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.BL;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //chk
            List<Ship> ship_list = new List<Ship>();
            char op;
            while(true)
            {
                op = menu();
                Console.Clear();
                if(op =='1')
                {
                    add_ship(ship_list);
                }
                else if(op =='2')
                {
                    position(ship_list);
                }
                else if(op=='3')
                {

                }
                else if(op=='4')
                {
                    replace(ship_list);
                }
                else if(op=='5')
                {
                    break;
                }
            }
        }
        static char menu()
        {
            Console.WriteLine("1) Add Ship");
            Console.WriteLine("2) View Ship Position");
            Console.WriteLine("3) View Ship Serial Number");
            Console.WriteLine("4) Change Ship Position");
            Console.WriteLine("5) Exit");
            char ch=Console.ReadLine()[0];
            return ch;
        }
        static void add_ship(List<Ship> ship_list)
        {
            Angle input=new Angle();
            Angle input2=new Angle();
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
            Ship ship=new Ship(name,input,input2);
            ship_list.Add(ship);
        }
        static void position(List<Ship> ship_list)
        {
            Console.WriteLine("Enter the Name of ship : ");
            string name = Console.ReadLine();
            for (int i = 0; i < ship_list.Count; i++)
            {
                if(name==ship_list[i].name)
                {
                    ship_list[i].display();
                    break;
                }
            }
        }
        static void replace(List<Ship> ship_list)
        {
            Console.WriteLine("Enter the Name of ship : ");
            string name = Console.ReadLine();
            for (int i = 0; i < ship_list.Count; i++)
            {
                if (name == ship_list[i].name)
                {
                    Angle input = new Angle();
                    Angle input2 = new Angle();
                    Console.WriteLine("Enter the Name : ");
                    string name1 = Console.ReadLine();
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
                    ship_list[i] = new Ship(name, input, input2);
                }
            }
        }
    }
}

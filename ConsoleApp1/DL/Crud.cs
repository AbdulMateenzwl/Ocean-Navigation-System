using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.BL;

namespace ConsoleApp1.DL
{
    internal class Crud
    {
        public static List<Ship> ship_list = new List<Ship>();
        public static bool if_exists(string name)
        {
            for (int i = 0; i < ship_list.Count; i++)
            {
                if (name == ship_list[i].name)
                {
                    return true;
                }
            }
            return false;
        }
        public static int index(string name)
        {
            for (int i = 0; i < ship_list.Count; i++)
            {
                if (name == ship_list[i].name)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int check_ship(Ship ship)
        {
            for (int i = 0; i < ship_list.Count; i++)
            {
                if (ship.X == ship_list[i].X && ship.Y==ship_list[i].Y)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

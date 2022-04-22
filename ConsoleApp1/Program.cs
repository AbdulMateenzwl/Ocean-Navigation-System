using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.BL;
using ConsoleApp1.DL;
using ConsoleApp1.UI;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            while(true)
            {
                op = Menu_Ui.menu();
                Console.Clear();
                if(op =='1')
                {
                    Ship output = Ui.take_input();
                    Crud.ship_list.Add(output);
                }
                else if(op =='2')
                {
                    Ui.position();
                }
                else if(op=='3')
                {
                    Ui.serial_num();
                }
                else if(op=='4')
                {
                    Ui.change_position();
                }
                else if(op=='5')
                {
                    break;
                }
            }
        }
    }
}

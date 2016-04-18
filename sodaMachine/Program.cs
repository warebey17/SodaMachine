using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace sodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            sodaMachine Sodamachine = new sodaMachine();
            
            while (!Sodamachine.checkMeatTotal())
            {
                Console.WriteLine("Please enter money for soda (1, 5, 10 or 25)");
                Sodamachine.acceptCoins(Convert.ToInt32(Console.ReadLine()));
            }
            while (!Sodamachine.checkOrangeTotal())
            {
                Console.WriteLine("Please enter money for soda (1, 5, 10 or 25)");
                Sodamachine.acceptCoins(Convert.ToInt32(Console.ReadLine()));
            }
            while (!Sodamachine.checkGrapeTotal())
            {
                Console.WriteLine("Please enter money for soda (1, 5, 10 or 25)");
                Sodamachine.acceptCoins(Convert.ToInt32(Console.ReadLine()));
            }
            Sodamachine.sodaSelection();

            Console.ReadLine();
        }
    }
}

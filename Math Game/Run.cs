using Math_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game
{
    public class Run
    {


        public static void Main(string[] args)
        {
            calculator calculator = new calculator();

            while (true)
            {
                calculator.setInput(1);
                calculator.setInput(2);

                Console.WriteLine($"1: {calculator.getNumber1()} 2: {calculator.getNumber2()}");

                calculator.operatorMessage();
                string choice = Console.ReadLine();
                int product = calculator.chooseOperation(choice);
                Console.WriteLine(product);
            }

        }

    }
    
 
}

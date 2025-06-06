using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Math_Game
{
    public class calculator
    { 
        
        public int number1 = 0;
        public int number2 = 0;
        public List<string> history = new List<string>();
        public operators operators = new operators();

        //setters and getters

        public void setNumber1(int number)
        {
            this.number1 = number;
        }

        public void setNumber2(int number)
        {
            this.number2 = number;
        }
        public int getNumber1()
        {
            return this.number1;
        }
        public int getNumber2()
        {
            return this.number2;
        }

        //Methods
        public void setInput(int toggle)
        {
            int number;
            switch (toggle)
            {
                case 1:
                    number = getInput();
                    setNumber1(number);
                    break;
                case 2:
                    number = getInput();
                    setNumber2(number);
                    break;
            }
        }


        public int getInput()
        {
            bool check  = false;
            int number = -1;
            while (!check) {
                Console.WriteLine("Enter Number between 0-100");
                string input = Console.ReadLine();  
                bool response  = int.TryParse(input, out number);
                if (response)
                {
                    if(number >= 0 && number <= 100)
                    {
                        check = true;
                    }
                    else
                    {
                        check= false;
                    }
                }
            }
            return number;
           
        }

        public int chooseOperation(string choice)
        {
            int number;
            while (true)
            {
                switch (choice)
                {
                    case "1":
                        number = operators.add(this.number1, this.number2);
                        addHistory("+", number);
                        return number;  
                        
                    case "2":
                        number = operators.subtract(this.number1, this.number2);
                        addHistory("-", number);
                        return number;
                    case "3":
                        number = operators.divison(this.number1, this.number2);
                        addHistory("/", number);
                        return number;
                    case "4":
                        number = operators.multiply(this.number1, this.number2);
                        addHistory("*", number);
                        return number;
                    case "5":
                        showHistory();
                        operatorMessage();
                        choice = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Invalid!");
                        operatorMessage();
                        choice = Console.ReadLine();
                        break;

                }
            }
            
        }

        public void addHistory(string symbol, int product)
        {
            this.history.Add($"{this.number1} {symbol} {this.number2} = {product}");
        }

        public void showHistory()
        {
            if(this.history == null)
            {
                Console.WriteLine("History is Empty.");
            }
            else
            {
                Console.WriteLine($"History. length: {this.history.Count}");
                for (int i = 0; i < this.history.Count; i++) 
                {
                    Console.WriteLine(this.history[i]);
                }
            }
               
        }

        public void operatorMessage()
        {
            Console.WriteLine("choose an operator\n 1. Add\n 2.Subtract\n 3.Division\n 4.Multiply\n 5.History ");
        }

        
    }
}

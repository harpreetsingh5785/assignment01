using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program
    {
        public static int MenuSelection()
        {
            bool validMenuSelect = false;
            string userInput = "";
            while (validMenuSelect == false)
            {
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");

                Console.WriteLine("Select any option by entering valid number");
                userInput = Console.ReadLine();

                if (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4" && userInput != "5" && userInput != "6" && userInput != "7")
                {
                    Console.WriteLine("That option is not valid, try again");
                }
                else
                {
                    validMenuSelect = true;
                }

            }
            Console.WriteLine();
            return int.Parse(userInput);
        }
        public static int CustomUserInput(string rectSide)
        {
            int number = 1;
            bool isValid = false;
            while (isValid == false)
            {
                Console.WriteLine($"Please enter the {rectSide} of your rectangle");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out number);

                if (result == false)
                {
                    Console.WriteLine("This is  not a valid inpute, please try again ");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Number can not be less than 0, please try again");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine($"The  {rectSide} of your rectangle is now  {number}");
                }
            }

            Console.WriteLine();
            return number;
        }
        static void Main(string[] args)
        {
            bool isValid = false;
            Console.WriteLine("1. Create default (1 unit * 1 unit) Rectangle");
            Console.WriteLine("2. Create custom Rectangle");
            while (isValid == false)
            {

                Console.WriteLine("Choose any menu item to begin");
                string Input = Console.ReadLine();
                if (Input == "1")
                {
                    isValid = true;
                    Rectangle rect = new Rectangle();
                    int perimeter = rect.GetPerimeter();
                    Console.WriteLine($"The Perimeter of Rectangle is {perimeter}");
                    int area = rect.GetArea();
                    Console.WriteLine($"The Area of Rectangle is {area}");
                    Console.WriteLine("Press any key to Exit");
                    Console.ReadKey();


                }
                else if (Input == "2")
                {
                    isValid = true;
                    int length = CustomUserInput("Length");
                    int width = CustomUserInput("Width");
                    Rectangle rect = new Rectangle();
                    rect.SetLength(length);
                    rect.SetWidth(width);
                    Console.WriteLine($"Your custom rectangle is {length} * {width} unit(s)");
                    int selection = 0;
                    while (selection != 7)
                    {
                        selection = MenuSelection();
                        switch (selection)
                        {
                            case 1:
                                Console.WriteLine($"The rectangle length is {rect.GetLength()}");
                                break;
                            case 2:
                                int lengthNew = CustomUserInput("length");
                                rect.SetLength(lengthNew);

                                break;
                            case 3:
                                Console.WriteLine($"The rectangle width is {rect.GetWidth()}");
                                break;
                            case 4:
                                int widthNew = CustomUserInput("width");
                                rect.SetWidth(widthNew);
                                break;
                            case 5:
                                Console.WriteLine($"The rectangle perimeter is {rect.GetPerimeter()}");
                                break;
                            case 6:
                                Console.WriteLine($"The rectangle area is {rect.GetArea()}");
                                break;
                        }
                        Console.WriteLine();
                    }
                    if (selection == 7)
                    {
                        Environment.Exit(0);
                    }



                }
                else
                {
                    Console.WriteLine("This menu item does not exist, try again");
                }
            }

        }
    }
}

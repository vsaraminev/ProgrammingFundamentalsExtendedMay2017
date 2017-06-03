using System;

namespace SMSTyping
{
    public class SMSTyping
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var message = "";

            for (int i = 0; i < n; i++)
            {
                var number = Console.ReadLine();
                var lenght = number.Length;
                var firstNum = number[0];

                if (lenght == 1)
                {
                    switch (number)
                    {
                        case "0":
                            message += " ";
                            break;
                        case "2":
                            message += "a";
                            break;
                        case "3":
                            message += "d";
                            break;
                        case "4":
                            message += "g";
                            break;
                        case "5":
                            message += "j";
                            break;
                        case "6":
                            message += "m";
                            break;
                        case "7":
                            message += "p";
                            break;
                        case "8":
                            message += "t";
                            break;
                        case "9":
                            message += "w";
                            break;
                    }
                }

                else if (lenght == 2)
                {
                    switch (firstNum)
                    {
                        case '2':
                            message += "b";
                            break;
                        case '3':
                            message += "e";
                            break;
                        case '4':
                            message += "h";
                            break;
                        case '5':
                            message += "k";
                            break;
                        case '6':
                            message += "n";
                            break;
                        case '7':
                            message += "q";
                            break;
                        case '8':
                            message += "u";
                            break;
                        case '9':
                            message += "x";
                            break;
                    }
                }

                else if (lenght == 3)
                {
                    switch (firstNum)
                    {
                        case '2':
                            message += "c";
                            break;
                        case '3':
                            message += "f";
                            break;
                        case '4':
                            message += "i";
                            break;
                        case '5':
                            message += "l";
                            break;
                        case '6':
                            message += "o";
                            break;
                        case '7':
                            message += "r";
                            break;
                        case '8':
                            message += "v";
                            break;
                        case '9':
                            message += "y";
                            break;
                    }
                }

                else if (lenght == 4)
                {
                    switch (firstNum)
                    {
                        case '7':
                            message += "s";
                            break;
                        case '9':
                            message += "z";
                            break;
                    }

                }
            }

            Console.WriteLine(message);
        }        
    }
}

using System;
using System.Linq;

namespace Phone
{
    public class Phone
    {
        public static void Main()
        {
            var phoneNumbers = Console.ReadLine()
              .Split(' ')
              .ToArray();

            var names = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var line = Console.ReadLine()
                .Split(' ')
                .ToArray();

            while (line[0] != "done")
            {
                if (line[0] == "call")
                {
                    GetCallMethod(phoneNumbers, names, line);
                }
                else if (line[0] == "message")
                {
                    GetMesageMethod(phoneNumbers, names, line);
                }

                line = Console.ReadLine()
                    .Split()
                    .ToArray();
            }
        }

        private static void GetCallMethod(string[] phoneNumbers, string[] names, string[] line)
        {
            var duration = 0;

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                if (line[1] == names[i])
                {
                    Console.WriteLine($"calling {phoneNumbers[i]}...");

                    var sumOfDigits = phoneNumbers[i].ToString();

                    foreach (var number in sumOfDigits)
                    {
                        if (number >= 48 && number <= 57)
                        {
                            var digit = number - '0';
                            duration += digit;
                        }
                    }
                }
                else if (line[1] == phoneNumbers[i])
                {
                    Console.WriteLine($"calling {names[i]}...");

                    var sumOfDigits = phoneNumbers[i].ToString();

                    foreach (var number in sumOfDigits)
                    {
                        if (number >= 48 && number <= 57)
                        {
                            var digit = number - '0';
                            duration += digit;
                        }
                    }
                }
            }

            if (duration % 2 != 0)
            {
                Console.WriteLine("no answer");
            }
            else
            {
                Console.WriteLine($"call ended. duration: {(duration / 60):d2}:{(duration % 60):d2}");
            }
        }

        private static void GetMesageMethod(string[] phoneNumbers, string[] names, string[] line)
        {
            var diff = 0;

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                if (line[1] == names[i])
                {
                    Console.WriteLine($"sending sms to {phoneNumbers[i]}...");

                    var sumOfDigits = phoneNumbers[i].ToString();

                    foreach (var number in sumOfDigits)
                    {
                        if (number >= 48 && number <= 57)
                        {
                            var digit = number - '0';
                            diff -= digit;
                        }
                    }
                }
                else if (line[1] == phoneNumbers[i])
                {
                    Console.WriteLine($"sending sms to {names[i]}...");

                    var sumOfDigits = phoneNumbers[i].ToString();

                    foreach (var number in sumOfDigits)
                    {
                        if (number >= 48 && number <= 57)
                        {
                            var digit = number - '0';
                            diff -= digit;
                        }
                    }
                }
            }

            if (diff % 2 != 0)
            {
                Console.WriteLine("busy");
            }
            else
            {
                Console.WriteLine($"meet me there");
            }
        }
    }    
}

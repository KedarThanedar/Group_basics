using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_basics
{
    public class IfElseSwitch
    {
        public static void CheckIfElse(int n1, string name1, int n2, string name2)
        {
            if (n1 > n2)
            {
                Console.WriteLine($"{name1} is larger than {name2}" );
            }
            else
            {
                if (n1.Equals(n2))
                {
                    Console.WriteLine($"{name1} is equal to {name2}");
                }
                else { Console.WriteLine($"{name1} is smaller than {name2}"); }
            }
        }

        public static string CheckSwitch(string serviceProvider)
        { 
            switch (serviceProvider) 
            {
                case "google":
                    return "bard";
                case "microsoft":
                    return "copilot";
                default:
                    return "chat gpt";

            }
        }

    }
}

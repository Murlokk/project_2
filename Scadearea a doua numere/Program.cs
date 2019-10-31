using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Test
{
    static void Main()
    {
        Console.Write("Enter number 1: ");
        string stringNumber1 = Console.ReadLine();
        int intergerNumber1 = int.Parse(stringNumber1);

        Console.Write("Enter number 2: ");
        string stringNumber2 = Console.ReadLine();
        int intergerNumber2 = int.Parse(stringNumber2);

        int intergerAnswer = intergerNumber1 - intergerNumber2;

        Console.Write("\nYour answer is: " + intergerAnswer);

        Console.Write("\n\nPes any key to exit... ");
        Console.ReadKey();

    }
}


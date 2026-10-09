// Fox, chicken, grain program

using System;

class Program
{
    // -------------------------
    // Subprograms
    // -------------------------
    static void procedure_example(string param1, string param2)
    {

    }

    static int function_example(int param1, int param2)
    {
        return param1 + param2;
    }

    static double add(double x, double y)
    {
        double xaddy = x + y;
        return xaddy;
    }
    static void johnkiriaku()
    {
        Console.WriteLine("we are gonna send you to a place you arent gonna like...");
    }

    // -------------------------
    // Main program
    // -------------------------
    static void Main()
    {
        johnkiriaku();
        Console.WriteLine("Enter two deciamls ples");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Convert.ToString(add(x, y)));
    }

}

//this is testing comments
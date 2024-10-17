using System;
using System.Runtime.ConstrainedExecution;

class Challenges
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Welcome to my coding challenge program. There will be a variety of different functions you will have to choose from. Please pick one.");

        Console.WriteLine("Today we are going to usse the number adder called SUM. Please input two numbers for us to add. \n");

        var number1 = Console.ReadLine();
        int number1int = int.Parse(number1);

        Console.Write("Wow! Your stupid! Please Input one more number!");

        var number2 = Console.ReadLine();
        int number2int = int.Parse(number2);

        Console.WriteLine("The sum of the number: " + number1 + " and the number: number2 " + "is equal to: " + Sum(number1int, number2int));

        Console.WriteLine("Let's try converting minutes into seconds. Give me a number to convert minutes to seconds.");
        var number3 = Console.ReadLine();
        int number3int = int.Parse(number3);

        Console.WriteLine(number3 + " Minutes converted to seconds is: " + Convert(number3int) + " seconds " );

        Sum(number1int, number2int);

        Console.WriteLine("Now input any number and I will add 1 digit to it.");
        var appendicitis = Console.ReadLine();
        int appendicitisint = int.Parse(appendicitis);

        Console.WriteLine(appendicitis + " and add 1 digit and you get: " + AddOne(appendicitisint));

        Console.WriteLine("Let's try calculating circuit power! \n");

        Console.WriteLine("Give me a value for your voltage.");
        var stupidity = Console.ReadLine();
        int stupidityint = int.Parse(stupidity);

        Console.WriteLine("Give me the current value human.");
        var foolishness = Console.ReadLine();
        int foolishnessint = int.Parse(foolishness);

        Console.WriteLine("Your circuit power is equal to: " + VoltConvert(stupidityint, foolishnessint));
        VoltConvert(stupidityint, foolishnessint);

        Console.WriteLine("Now I will convert years to days. Give me a number Juniper.");
        var whopperjuniordoubletripplewhopper = Console.ReadLine();
        int whopperjuniordoubletripplewhopperint = int.Parse(whopperjuniordoubletripplewhopper);

        Console.WriteLine("You are: " + CalcAge(whopperjuniordoubletripplewhopperint) + " days old.");

        Console.WriteLine("Now let's find the area of a triangle, first me give a height.");
        var walterwhite = Console.ReadLine();
        int walterwhiteint = int.Parse(walterwhite);

        Console.WriteLine("Now igve me the base of your triangle");
        var jessepinkman = Console.ReadLine();
        int jessepinkmanint = int.Parse(jessepinkman);

        Console.WriteLine("THE AREA 51 OF YOUR TRIANGLE IS: " + CalcArea(walterwhiteint, jessepinkmanint)); 
        CalcArea(walterwhiteint, jessepinkmanint);

        Console.WriteLine("Now give me a number and I will see if it's greater or less than 0. \n please give me a number");
        var snickerdoodle = Console.ReadLine();
        int snickerdoodleint = int.Parse(snickerdoodle);

        Console.WriteLine(lospolloshermanos(snickerdoodleint));

    }

    public static int Sum(int number1, int number2)
    { return number1 + number2; }

    public static int Convert(int number)

    {
        return number * 60;
    }

    public static int AddOne(int appendicitis)
    {
        return appendicitis += 1;
    }

    public static int VoltConvert(int stupidity, int foolishness)
    {
        return stupidity * foolishness;
    }

    public static int CalcAge(int whopperjuniordoubletripplewhopper)
    {
        return whopperjuniordoubletripplewhopper * 365;
    }

    public static float CalcArea(float walterwhite, int jessepinkman)
    {
        return (walterwhite * jessepinkman) / 2;
    }

    public static bool lospolloshermanos(int snickerdoodle)
    {
        if (snickerdoodle <= 0)
        {
            return true;
        }
        return false;
    }
}




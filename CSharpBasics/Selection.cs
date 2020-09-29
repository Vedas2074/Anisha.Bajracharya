using System;

class SelectionStatement
{
    public void LearnIfElse()
    {
        Console.WriteLine("Enter your age:");
        string ageString = Console.ReadLine();
        byte age = byte.Parse(ageString);
        if (age > 60)
        {
            Console.WriteLine("You are eligible for pension.");
        }
        else if(age > 50)
        {
            Console.WriteLine("You are about to be eligible for pension.");
        }
        else
        {
            Console.WriteLine("You are not eligible for pension.");

        }

    }
    public void LearnSwitchCases()
    {
        Console.Write("Enter your hobby: ");
        string hobby = Console.ReadLine();

        switch(hobby)
        {
            case "books":
            Console.WriteLine("You are very good academician. ");
            break;

            case "badminton":
            Console.WriteLine("You are very good player. ");
            break;


            case "swimming":
            Console.WriteLine("You are very good swimmer. ");
            break;


            case "dancing":
            Console.WriteLine("You are very good dancer. ");
            break;

            default:
            Console.WriteLine("Default case");
            break;

        }
    }
}
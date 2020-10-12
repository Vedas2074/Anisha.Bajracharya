using System;

class IterationStatement
{

    static void Main123()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnForLoops();
    }
    public void LearnForLoops()
    {
        int i;
        for(i=0; i < 10; i++)
        {
            Console.WriteLine("Hello World!");
        }

        // int[] numbers = {4, 5, 63, 56, 64, 12};
        // for (int x = 0; x < numbers.Length; x++)
        // {
        //     Console.WriteLine(numbers[x]);
        // }

        int[] numbers1 = {4, 5, 23, 45, 12};
        foreach (int num in numbers1)
        {
            if(num%2 == 1)
            {
            Console.WriteLine(num);
            }
        }

        int[] numbers2 = {4, 5, 63, 56, 64, 12, 34, 55, 21, 38};
        for (int x = 0; x < numbers2.Length; x++)
        {
            if(numbers2[x]%2 == 0)
            {
            Console.WriteLine(numbers2[x]);
            }
        }
    }

    // public void LearnWhileLoops()
    // {
    //     int i = 0;
    //     while (i < 10)
    //     {
    //         Console.WriteLine("Hello Again");
    //         i++;
    //     }
    // }

    void LearnWhileLoops()
    {
        // string confirm = "Y";
        // while (confirm == "Y")
        // {
        //     Console.WriteLine("Hello World!");

        //     Console.WriteLine("Want to print one more time?");
        //     confirm = Console.ReadLine();
        // }

        string confirm1 = "Y";
        do
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Want to print one more time?");
            confirm1 = Console.ReadLine();
        }while (confirm1 == "Y");
    }

    



}
using System;
//using AccessModifierAndMethods;
using LearningClasses;
//using P = LearningClasses.Person;
// namespace CSharpBasics
// {
//     class Program
//     {
//         static void Main()
//         {
//             SelectionStatement selectionStatement = new SelectionStatement();
//             selectionStatement.LearnIfElse();
//             selectionStatement.LearnSwitchCases();
//         }
//     }
// }
class Program
{
    // static void Main2342()
    // {
    //     //IterationStatement iterationStatement = new IterationStatement();
    //     //iterationStatement.LearnForLoops();
    //     AccessModifier accessModifier = new AccessModifier();
    //     accessModifier.DoSomething();

    //     Human human = new Human();
    //     human.name = "Bishnu";
    //     human.Age = 179;

    //     var x = human.Address;
    // }
    static void Main2342()
    {
    
        var person1 = new Person("Ramesh", "Bhaktapur", 23);
        var person2 = new Person("Ram", "Bhaktapur", 20);
        var person3 = new Person("Shyam", "Bhaktapur", 40);
        var person4 = new Person();
        
        var x = Person.ScientificName;

        //Person.Do();

        var y = Math.Sqrt(25);

        var s = Calculator.Sum<int>(23, 24);
        var t = Calculator.Sum<decimal>(233454.23m, 244514.23m);

        Rectangle rectangle = new Rectangle();
        rectangle.Length = 23.6;
        rectangle.Breadth = 6.32;
        var result = rectangle.GetArea();
    }
}

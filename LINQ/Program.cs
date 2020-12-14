using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ - Language Integrated Query
            int[] numbers = {23, 45, 67, 12, 34, 45, 78, 90, 11, 14, 16, 27};

            // var result = numbers.Select(x => x < 75 && x > 20);

            //using method syntax - lambda expression
            var result1 = numbers.Where(x => x < 75 && x > 20);

            //Query syntax - query expression
            var result2 = from x in numbers 
                          where x < 75 && x > 20
                          select x;

            string[] names = {"Bishnu", "Bipin", "Rojeena", "Anjana", "Anisha", "Badal"};

            //Find names that starts with letter 'B' and having length less than 6

            var result3 = from name in names
                          where name.StartsWith("B") && name.Length < 6
                          select name;

            //Projections
            var result4 =  from num in numbers
                            select num * num;

            //Ordering
            var result5 =  from num in numbers
                            orderby num
                            select num;

            var result6 = numbers.Take(5);
            var result7 = numbers.Skip(5).Take(5);

            //Quantifiers
            var isEvenThere = numbers.Any(num => num % 2 == 0);
            var areAllEvens = numbers.All(num => num % 2 == 0);
            var is26there = numbers.Contains(26);

            var result8 = Enumerable.Range(1, 1000);
            var result9 = Enumerable.Repeat("Hello world", 10);


            List<Person> people = new List<Person>()
            {
                new Person() {Id = 1, FirstName ="ansa", LastName = "bajra", Address = "gabahal", Age = 21},
                new Person() {Id = 2, FirstName ="resa", LastName = "bajra", Address = "patan", Age = 11},
                new Person() {Id = 3, FirstName ="sela", LastName = "shakya", Address = "habahal", Age = 31},
                new Person() {Id = 4, FirstName ="G", LastName = "khadka", Address = "ktm", Age = 32},
                new Person() {Id = 5, FirstName ="H", LastName = "khadka", Address = "bhkt", Age = 14},
            };
            // Find all people who live in ktm
            var result10 = from person in people
                            where person.Address == "ktm"
                            select person;
            
            //Find all people who are minors
            var result11 = from person in people
                            where person.Age < 18
                            select person;
            
            // Find all people who live in bhkt
            var result12 = from person in people
                            where person.Address == "bhkt" && person.Age < 18
                            select person;

        }
    }
}

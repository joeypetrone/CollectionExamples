using System;
using System.Collections.Generic;

namespace CollectionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var instructors = new List<string>();
            var students = new List<string>();
            var evening11 = new List<string>();

            var numbers = new List<int>();

            instructors.Add("Jameka");
            instructors.Add("Nathan");
            instructors.Add("Dylan");

            numbers.Add(1);
            numbers.Add(3);
            numbers.Add(5);

            students.Add("Aaron");
            students.Add("John");
            students.Add("Monique");

            //add multiple at once from an existing list
            evening11.AddRange(instructors);
            evening11.AddRange(students);

            foreach (var person in evening11)
            {
                Console.WriteLine($"{person} is in evening cohort 11.");
            }



        }
    }
}

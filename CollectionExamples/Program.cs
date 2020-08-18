﻿using System;
using System.Collections.Generic;

namespace CollectionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lists are a general purpose collection that is pretty good at everything
            var instructors = new List<string>();
            var students = new List<string>();
            var evening11 = new List<string>();

            var numbers = new List<int>();

            //adding single item
            instructors.Add("Jameka");
            instructors.Add("Nathan");
            instructors.Add("Dylan");

            //items need to be of the right type
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

            //is the iten in the list?
            var steveIsInE11 = evening11.Contains("Steve");

            //ternary inside interpolated strings have to be in parantheses
            Console.WriteLine($"Steve is {(steveIsInE11 ? "" : "not ")}in E11.");

            //just the first match
            var matchingPerson = evening11.Find(person => person.StartsWith("J"));

            Console.WriteLine($"{matchingPerson} starts with J.");

            //in a list, the index is the key
            Console.WriteLine($"{students[1]} is the student at the index of 1.");

            //dictionaries have 2 generic type parameters
            var words = new Dictionary<string, string>();

            //dictionary entries are made of key value pairs, and both must be supplied to add anything
            words.Add("pedantic", "Like a pedant");
            words.Add("congratulate", "to be excited for; celebrate");
            words.Add("scrupulous", "diligent, thorough, extremely attentive to details");

            //keys must be unique, this won't work
            words.Add("congratulate", "not a real thing");

            Console.WriteLine($"The fake definition of Congratulations is {words["congratulate"]}");

            //foreach (var entry in words)
            //{
            //    string word;
            //    string definition;

            //    entry.Deconstruct(out word, out definition);

            //    Console.WriteLine($"The fake definition of {entry.Key} is {entry.Value}");
            //}

            foreach (var (word, definition) in words)
            {
                Console.WriteLine($"The fake definition of {word} is {definition}");
            }

            var wordsWithMultipleDefinitions = new Dictionary<string, List<string>>();

            wordsWithMultipleDefinitions.Add("Scrupulous", new List<string>() 
            {
                "Diligent", 
                "Thorough",
                "Extremely attentive to detail"
            });


        }
    }
}

// Created by: Johanna Liu
// Created on: Mar 2022
//
// This program does basic math
using System;

class Program
{
    public static void Main(string[] args)
    {

        // This function states user's address input. 
        int age;

        //Input 
        Console.WriteLine("This program checks users eligibility for movies.");
        Console.WriteLine("");
        Console.Write("Enter age: ");
        age = Convert.ToInt32(Console.ReadLine());

        //Process
        if (age >= 17)
            Console.WriteLine("You are eligible to watch a R-rated movie.");
        else if (age >= 13)
            Console.WriteLine("You are eligible to watch a PG-13 rated movie.");
        else if (age >= 5)
            Console.WriteLine("You are eligible to watch a PG or G rated movie.");
        else
            Console.WriteLine("You are too young for most things.");

        Console.WriteLine("\nDone.");
    }
}
//Felipe Ruiz
//methods 

using Microsoft.VisualBasic;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace MethodsExercise102020
{
    class Program
    {
        //--------------exercise 2-------------------------
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;

        }
        static void Main(string[] args)
        {
            //--------exercise 2 end-----------------
            var amountOfCars = Sum(2, 6);
            var multi = Multiply(60, 2, 4);

            Console.WriteLine($"You total car amount:  {amountOfCars}");
            Console.WriteLine($"You total multiplication:  {multi}");


            //--------------------------exercise1----------------------
            //Name: Michael
            //Favorite Color: Blue
            //Favorite Animal: Walrus
            //Favorite Band: The Beatles

            Console.WriteLine("hello - what is your first name");
            var userName = Console.ReadLine();

            Console.WriteLine($"hello {userName} - what is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} really wow so is mine - what animal you like most");
            var animal = Console.ReadLine();

            Console.WriteLine($"Great {animal} - the name of your band");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}, here is your profile");

            Console.WriteLine("profile ------------");
            Console.WriteLine($"name: {userName}");
            Console.WriteLine($"favorite color: {color}");
            Console.WriteLine($"favorite animal: {animal}");
            Console.WriteLine($"favorite band: {band}");






        }
    }
}

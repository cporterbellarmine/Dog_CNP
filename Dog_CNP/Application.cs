/**
 * Application of the class Dog.
 * @author Rob Kelley
 * @author cporter
 * @version 1/12/2020
 * CS-311 Programming Project 1
 * Spring 2020
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_CNP
{
    class Application
    {
        public static void Main(string[] args)
        {

            Dog dog1 = new Dog();

            Console.WriteLine($"Test of empty constructor: {dog1.ToString()}");
            Console.WriteLine();

            Dog dog2 = new Dog(2, "Alfie");
            Dog dog3 = new Dog(100, "Vampy");
            Dog dog4 = new Dog(6, "Chico");

            Console.WriteLine($"{dog2.GetName()} is {dog2.GetAge()} years old in human years and {dog2.CalcDogYears()} in dog years. ");
            Console.WriteLine();

            Console.WriteLine($"{dog3.GetName()} is {dog3.GetAge()} years old in human years and {dog3.CalcDogYears()} in dog years. ");
            Console.WriteLine();

            Console.WriteLine($"{dog4.GetName()} is {dog4.GetAge()} years old in human years and {dog4.CalcDogYears()} in dog years. ");
            Console.WriteLine();

        }//end main
    }//end class
}//end namespace

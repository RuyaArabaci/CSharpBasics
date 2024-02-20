using System;

namespace CSharpBasics
{
    public class Program()
    {
        static void Main(string[] args)
        {
            //the text is stored as a sequential read-only collection of Char objects.
            string studentName = "Cihat";
            string studentSurname = "Çetin";
            string studentAge = "17";

            Console.WriteLine(studentName);
            Console.WriteLine($"{studentName} {studentSurname}");
            Console.WriteLine($"Student name is {studentName}.");
            Console.WriteLine($"Student name is {studentName} and age is {studentAge}.");
            // We can use $ and {} signs for write clear codes.
            // WARNING!! We can just use srting values.

            Console.WriteLine($"Student name's length is {studentName.Length} and age's length is {studentAge.Length}.");
            // Length tool is show us the length of the variables.

            Console.WriteLine($"{studentName.ToLower()} {studentSurname.ToUpper()}");
            // ToLower() converts all the letters lowercase and ToUpper() converts all the letters uppercase.

            Console.WriteLine($"{studentName.Replace("Cihat" , "Cihan")} {studentSurname.Replace("t", "l")}");
            // We can use Replace(x,y) tool for change all the x variables to y. But it is not constant changing.

            Console.WriteLine($"{studentName.Contains("h")} {studentSurname.Contains("h")}");
            // Contains() tool helps us relize whether it is present or not.

            Console.WriteLine(studentSurname.Substring(3,2));
            //If we use .Substring(7,3), the system bring eighth char of our string value and returns the two values behind it. The first intager show us the started piece. second intager show how many piece is printed. 
     
            Console.ReadLine();
        }
    }
}
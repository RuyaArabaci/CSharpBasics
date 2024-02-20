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
            // We can use Replace(x,y) method for change all the x variables to y. But it is not constant changing.

            Console.WriteLine($"{studentName.Contains("h")} {studentSurname.Contains("h")}");
            // Contains() method helps us relize whether it is present or not.

            Console.WriteLine(studentSurname.Substring(3,2));
            //If we use .Substring(7,3), the system bring eighth char of our string value and returns the two values behind it. The first intager show us the started piece. second intager show how many piece is printed. 

            string str = "hello";
            string? nullStr = null;
            // string? and string are different in terms of nullable reference types.String? represents a nullable string, which is a string that can have a value or be null. The ? after the type indicates that the variable can be assigned a value of the specified type or be assigned null.Without the ?, the string variable is treated as a regular string, and it must always have a valid string value.
            string emptyStr = String.Empty;
            // We use "System.String" object in this code row.
            // The null character can be displayed and counted, like other chars.

            Console.WriteLine(str);
            Console.WriteLine(nullStr);
            Console.WriteLine(emptyStr);


            System.Text.StringBuilder sb = new System.Text.StringBuilder("Yello, World!");
            //The StringBuilder class creates a string buffer that offers better performance if your program performs many string manipulations. The StringBuilder string also enables you to reassign individual characters, something the built-in string data type doesn't support.
            sb[0] = 'H';
            System.Console.WriteLine(sb.ToString());


            string days = "Monday-Tuesday+apple-Wednesday";
            Console.WriteLine(days);
            Console.WriteLine(days.Remove(14,6));
            Console.WriteLine(days);
            //Remove() method is helps to delete some chars to variable ,but, it is not mean this changes permanent. 

            Console.ReadLine();
        }
    }
}
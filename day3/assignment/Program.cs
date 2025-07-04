using System;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region Q1
        // Write a program that allows the user to enter a number then print it.
        //Console.WriteLine("Please Enter Number");
        //int number = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("number input is: " + number);

        //  طريقة تانية
        //Console.WriteLine("Please Enter Number");
        //int.TryParse(Console.ReadLine(), out int number);
        //Console.WriteLine("number input is: " + number);
        #endregion

        #region Q2
        //Write C# program that converts a string to an integer, but the string contains non-numeric characters
        //. And mention what will happen
        //Console.WriteLine("Please Enter any string: ");
        //int x = Convert.ToInt32(Console.ReadLine()); // invalid exception

        // طريقة ثانية 
        //Console.WriteLine("Please Enter any string: ");
        //int.TryParse(Console.ReadLine(), out int x);
        //Console.WriteLine(x);
        //Console.WriteLine("return 0 becouse can't convert string to int");



        #endregion

        #region Q3
        // Write C# program that Perform a simple arithmetic operation with floating-point numbers And
        // mention what will happen
        //float Num1 = 10.5f;
        //float num2 = 7.52f;
        //Console.WriteLine(Num1 + num2);


        #endregion


        #region Q4
        // Write C# program that Extract a substring from a given string.
        //Console.Write("Enter word to extract : ");
        //string s = Console.ReadLine();

        //Console.Write("Enter start number extract : ");
        //int.TryParse(Console.ReadLine(), out int start);

        //Console.Write("Enter End number extract : ");
        //int.TryParse(Console.ReadLine(), out int end);

        //string result = s.Substring(start, end);

        //Console.WriteLine(result);


        #endregion

        #region Q5
        // Write C# program that Assigning one value type variable to another and modifying the value of
        // one variable and mention what will happen

        //int x = 10;
        //int y = x;

        //x++;
        //Console.WriteLine("After Modificateion:");
        //Console.WriteLine("x =" + x);
        //Console.WriteLine("y = " + y);
        // dont change value Y becuse x and y value type


        #endregion

        #region Q6
        //  Write C# program that Assigning one reference type variable to another and modifying the
        //    object through one variable and mention what will happen

        //Class1 c1 = new Class1();
        //Console.WriteLine($"P1.x = {c1.x} "); // 10 defult value
        //Console.WriteLine($"P1.x = {c1.y} "); // 20 defult value

        //Class1 c2 = new Class1() { x = 1 , y = 2};

        //Console.WriteLine($"P1.x = {c2.x} "); // 1 
        //Console.WriteLine($"P1.x = {c2.y} "); // 2 

        //c2 = c1;

        //Console.WriteLine("After Changes");
        //Console.WriteLine($"P1.x = {c1.x} "); // 10 
        //Console.WriteLine($"P1.x = {c1.y} "); // 20 

        //Console.WriteLine($"P1.x = {c2.x} "); // 10
        //Console.WriteLine($"P1.x = {c2.y} "); // 20



        #endregion

        #region Q7
        //// Write C# program that take two string variables and print them as one variable
        //Console.WriteLine("enter One String: ");
        //string? s1 = Console.ReadLine(); // exple ola

        //Console.WriteLine("enter Two String: ");
        //string? s2 = Console.ReadLine(); // abdullah

        //string s3 = s1 + " " + s2;
        //Console.WriteLine(s3); // ola abdullah



        #endregion

        #region Q8
        // Write a program that calculates the simple interest given the principal amount, rate of interest, and time.

        //Console.Write("Enter the Principal Amount : ");
        //double.TryParse(Console.ReadLine(), out double amount);
        //Console.Write("Enter the rate of intersets : ");
        //double.TryParse(Console.ReadLine(), out double rate);
        //Console.Write("Enter the time : ");
        //int.TryParse(Console.ReadLine(), out int time);

        //double interest = (amount * rate * time) / 100.0;

        //Console.WriteLine($"Your interest is {interest}");


        #endregion

        #region Q9
        // Write a program that calculates the Body Mass Index(BMI) given a person's weight
        // in kilograms and height in meters.


        //Console.Write("Enter the weight in KiloGrams : ");
        //double.TryParse(Console.ReadLine(), out double weight);
        //Console.Write("Enter hieght in meters : ");
        //double.TryParse(Console.ReadLine(), out double hieght);

        //double Bmi = (weight) / (weight * hieght);

        //Console.WriteLine($"Your BMI Based on your inputs = {Bmi}");





        #endregion


        #region Q10
        // Write a program that uses the ternary operator to check if the temperature is too hot,
        // too cold, or just good. Assign the result in a variable then display the result. 
       




            #endregion

        }
    }
}

using System;
using System.ComponentModel;
using System.Security.Cryptography;
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

            //Console.WriteLine("enter temperature: ");
            //int.TryParse(Console.ReadLine(), out int temp);
            //string result =  temp < 10 ? "Just Cold" : (temp > 30) ? "Just Hot" : "Good";
            //Console.WriteLine(result);






            #endregion

            #region Q11
            //Console.Write("Enter Date :");
            //DateOnly.TryParse(Console.ReadLine(), out DateOnly date);

            //Console.WriteLine($"Today's Date: {date.Day},{date.Month},{date.Year}");
            //Console.WriteLine($"Today's Date: {date.Day}/{date.Month}/{date.Year}");
            //Console.WriteLine($"Today's Date: {date.Day}-{date.Month}-{date.Year}");






            #endregion

            #region Q12
            //12- Write a program that takes a number from the user then print yes if that number can
            //be divided by 3 and 4 otherwise print no.

            //Console.WriteLine("enter Your Number");
            //int.TryParse(Console.ReadLine(), out int num);
            //if(num % 3 == 0 && num % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}






            #endregion

            #region Q13
            // 13- Write a program that allows the user to insert an integer then print negative if
            // it is negative number otherwise print positive.
            //Console.WriteLine("enter Your Number");
            //int.TryParse(Console.ReadLine(), out int num);

            //if(num < 0)
            //{
            //    Console.WriteLine("the number is negative ");
            //}else
            //{
            //    Console.WriteLine("the number is positive ");
            //}



            #endregion


            #region Q14
            // Write a program that takes 3 integers from the user
            // then prints the max element and the min element.

            //Console.Write("Enter Number1: ");
            //int.TryParse(Console.ReadLine(), out int num1);


            //Console.Write("Enter Number2: ");
            //int.TryParse(Console.ReadLine(), out int num2);


            //Console.Write("Enter Number3: ");
            //int.TryParse(Console.ReadLine(), out int num3);


            //int max = 0, min = 0;
            //if (num1 > num2 && num1 > num3)
            //    max = num1;
            //else if (num2 > num3)
            //    max = num2;
            //else
            //    max = num3;

            //if (num1 < num2 && num1 < num3)
            //    min = num1;
            //else if (num2 < num3)
            //    min = num2;
            //else
            //    min = num3;


            //Console.WriteLine($"Max = {max}");
            //Console.WriteLine($"Min = {min}");
            #endregion

            #region Q15
            //15 - Write a program that allows the user to insert an integer number
            //then check If a number is even or odd.
            //Console.WriteLine("enter Your Number");
            //int.TryParse(Console.ReadLine(), out int num);

            //if(num % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}

            #endregion


            #region Q16
            // Write a program that takes character from the user then if it
            // is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //Console.WriteLine("enter The Charactar: ");
            //char? c = Convert.ToChar(Console.ReadLine());
            //switch (c)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'o':
            //    case 'i':
            //    case 'u':
            //    case 'A':
            //    case 'E':
            //    case 'O':
            //    case 'I':
            //    case 'U':
            //        Console.WriteLine("vowel");
            //        break;
            //    default:
            //        Console.WriteLine("consonant");
            //        break;
            //}

            #endregion

            #region Q17
            // Write a program to input the month number and print the number of days in that month.

            //Console.Write("Enter Month Number: ");
            //int.TryParse(Console.ReadLine(), out int month);

            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("31 Days");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("30 Days");
            //        break;
            //    case 2:
            //        Console.WriteLine("28 or 29 Days");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Month");
            //        break;
            //}

            #endregion


        }
    }
}

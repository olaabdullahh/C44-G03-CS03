using System.Globalization;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region float And Discard
            //float MyFloat = 10.123456789F;
            //Console.WriteLine(MyFloat); // 10.123457
            //double MyDouble = 10.123456789123456789; //10.123456789123457
            //Console.WriteLine(MyDouble);
            //decimal MyDecimal = 10.123_456_789_123_456_789_123_456_789M; // Discard Readbility
            //Console.WriteLine(MyDecimal); // 10.123456789123456789123456789M

            //long number = 100_000_000_000;// discard underscorses
            //Console.WriteLine($"{number:c}");

            //CultureInfo culture = new CultureInfo("ar-SA");
            //Console.WriteLine(number.ToString("c", culture));
            #endregion

            #region casting
            #region Implicit And Execpicit casting
            #region Exmple01
            //int x = 1000000; // 4 byte
            //long y = x; // 8 byte - implicit Casting
            //Console.WriteLine(y); // 1000000


            //long x = 100000000;

            //checked
            //{
            //    int y = (int)x; // excepitit casting using cating operator
            //    unchecked
            //    {
            //        Console.WriteLine(y); // overflow 
            //    }
            //}


            // protective code

            //long k = 1000000000000;
            //if(k > int.MaxValue || k<int.MinValue)
            //{
            //    Console.WriteLine("Exception will be thrown");
            //}
            //else
            //{
            //    int M = (int)k;
            //    Console.WriteLine(M);
            //}


            //object number = 10000;

            //int x = number.GetType() == typeof(int) ? (int)number : 0;
            //int result = x + 10;
            //Console.WriteLine(result);

            #endregion

            #region Example 02

            //int x = 10;
            //float y = x; // implicit casting


            //decimal x = 10.100M;
            //int y = (int)x; // exeplicit casting unsafe mybe loss of data


            #endregion


            #endregion


            #region convert
            //Console.WriteLine("Please ENTER Your Data: ");
            //string? name = Console.ReadLine();
            //Console.WriteLine("Age: ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Salary: ");
            //decimal salary = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine("name: " + name);
            //Console.WriteLine("Age: " + Age);
            //Console.WriteLine("salary: " + salary);


            #endregion
            // console.clear() clear console

            #region Parse



            #endregion

            #endregion
        }
    }
}

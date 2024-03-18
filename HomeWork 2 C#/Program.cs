using System.Globalization;

namespace HomeWork_2_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 5, 1, 6 };
            Console.WriteLine(Min(arr));
        }
         public static int Min(params int[] nums)
        {
            int min = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (min > nums[i])
                {
                    min = nums[i];
                    return min;
                }                           
            }
            Console.WriteLine(Min); 
            return min;
        }



            /* static void Main(string[] args0)
         {
             Console.WriteLine(Area(2, 3, 4, 2, 2));
         }
         public static int Area(int r)
         {
             int p = 3;
             return p * (r * r);
         }
         public static int Area(int a, int b)
         {
             return a * b;
         }
         public static int Area(int a, int b, int c)
         {
             return 2 * (a * b + a * c + b * c);
         }
         public static int Area(int p, int r, int a, int b, int c)
         {
              p=(a+b+c)/2;
              return p * r;
         }*/
        

    }
}

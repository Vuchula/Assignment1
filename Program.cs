using System;
 
namespace Assignment1_Fall20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            PrintTriangle(n);
 
            int n2 = 5;
            PrintSeriesSum(n2);
 
            int[] A = new int[] { 1, 2, 2, 6 }; ;
            bool check = MonotonicCheck(A);
            Console.WriteLine(check);
 
            int[] nums = new int[] { 3, 1, 4, 1, 5 };
            int k = 2;
            int pairs = DiffPairs(nums, k);
            Console.WriteLine(pairs);
 
            string keyboard = "abcdefghijklmnopqrstuvwxyz";
            string word = "dis";
            int time = BullsKeyboard(keyboard, word);
            Console.WriteLine(time);
 
            string str1 = "goulls";
            string str2 = "gobulls";
            int minEdits = StringEdit(str1, str2);
            Console.WriteLine(minEdits);
 
        }
 
        public static void PrintTriangle(int n)
        {
            try
            {
                int i, j;
                int space = n - 1;
                for (j = 1; j <= n; j++)
                {
                    for (i = 1; i <= space; i++)
                        Console.Write(" ");
                    space--;
                    for (i = 1; i <= 2 * j - 1; i++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                           }
            catch
            {
                Console.WriteLine("Exception occured while computing PrintTriangle()");
            }
        }
 
        public static void PrintSeriesSum(int n)
        {
            try
            {
                int sum = 0;
                for (int i = 1; i <= n; i++)
				{

					Console.Write("{0} ", (2 * i) - 1);
                    sum += 2*i-1;
                    
                }
                Console.WriteLine();
                Console.WriteLine("Sum of the Series:"+ sum);
            
            }

            catch
            {
                Console.WriteLine("Exception occured while computing PrintSeriesSum()");
            }
        }
 
        public static bool MonotonicCheck(int[] A)
        {
            try
            {
                static bool Increasing(int[] A)
                {

                    for (int i = 1; i < A.Length; ++i)
                    {
                        if (A[i] < A[i - 1])
                        {
                            return false;
                        }
                    }

                    return true;
                }

                static bool Decreasing(int[] A)
                {


                    for (int i = 1; i < A.Length; ++i)
                    {
                        if (A[i] > A[i - 1])
                        {
                            return false;
                        }
                    }
                    return true;
                }
                return Increasing(A) || Decreasing(A);
            }

            catch
            {
                Console.WriteLine("Exception occured while computing MonotonicCheck()");
            }
 
            return false;
        }
 
        public static int DiffPairs(int[] J, int k)
        {
            try
            {
                int count = 0;

                for (int i = 0; i < J.Length; i++)
				{
					for (int j = i + 1; j < J.Length; j++)
					{
						if (J[i] - J[j] == k || J[j] - J[i] == k)
                            count++;
					}
				}
                return count;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing DiffPairs()");
            }
 
            return 0;
        }
 
        public static int BullsKeyboard(string keyboard, string word)
        {
            try
            {
                
            }
            catch
            {
                Console.WriteLine("Exception occured while computing BullsKeyboard()");
            }
 
            return 0; 
        }
 
        public static int StringEdit(string str1, string str2)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing StringEdit()");
            }
 
            return 0;
        }
    }
 
}



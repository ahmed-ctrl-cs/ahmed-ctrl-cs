using System;
using System.Globalization;
namespace Random_App
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("This takes from you 5 digits that has 2 digits that sum upto 10");
            int[] nums = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter the number number {i + 1} : ");
                nums[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"You still have {4 - i} numbers left");
            }
            for (int i = 0; i <= nums.Length; i++)
            {
                for (int j = 0; j <= nums.Length; j++)
                {
                    if (nums[i] + nums[j] != 10) continue;
                    else
                    {
                        Console.WriteLine($"{nums[i]} + {nums[j]} = 10");
                    }
                    break;
                }
                break;
            }
        }
    }
}
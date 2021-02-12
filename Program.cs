using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManupulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList(); // read and fill the List

            int LengthOfNums = nums.Count;
            int actionCounter = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    if (actionCounter != 0)
                    {
                        Console.WriteLine(string.Join(' ', nums));
                    }
                    
                    break;
                }

                List<string> givenCommand = command       
                    .Split()
                    .ToList();

                // create an List of Commands

                if (givenCommand[0] == "Add")
                {
                    nums.Add(int.Parse(givenCommand[1]));
                    actionCounter++;
                }

                if (givenCommand[0] == "Remove")
                {
                    nums.Remove(int.Parse(givenCommand[1]));
                    actionCounter++;
                }

                if (givenCommand[0] == "RemoveAt")
                {
                    nums.RemoveAt(int.Parse(givenCommand[1]));
                    actionCounter++;
                }

                if (givenCommand[0] == "Insert")
                {
                    nums.Insert(int.Parse(givenCommand[2]), int.Parse(givenCommand[1]));
                    actionCounter++;
                }

                if (givenCommand[0] == "Contains")
                {
                    if (nums.Contains(int.Parse(givenCommand[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");     
                    }
                }

                if (givenCommand[0] == "PrintEven")
                {  
                    List<int> evenNumbers = GetEvenNums(nums, LengthOfNums);
                    Console.WriteLine(string.Join(" ", evenNumbers));
                }

                if (givenCommand[0] == "PrintOdd")
                {
                    List<int> oddNumbers = GetOddNums(nums, LengthOfNums);
                    Console.WriteLine(string.Join(" ", oddNumbers));
                }

                if (givenCommand[0] == "GetSum")
                {
                    SumNumbers(nums);
                    int sumElements = SumNumbers(nums);
                    Console.WriteLine(sumElements);
                }

                if (givenCommand[0] == "Filter" && givenCommand[1] == ">=")
                {
                    int conditionNumber = int.Parse(givenCommand[2]);
                    List<int> equalOrBigger = new List<int>(nums.Count);

                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] >= conditionNumber)
                        {
                            equalOrBigger.Add(nums[i]);
                        }                        
                    }

                    Console.WriteLine(string.Join(' ', equalOrBigger));
                    // call method to get from nums bigger >= 43 numbers
                    // GetBiggerNumbers(int num)
                }

                if (givenCommand[0] == "Filter" && givenCommand[1] == "<")
                {
                    int conditionNumber = int.Parse(givenCommand[2]);
                    List<int> less = new List<int>(nums.Count);

                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] < conditionNumber)
                        {
                            less.Add(nums[i]);
                        }
                    }

                    Console.WriteLine(string.Join(' ', less));
                }

                if (givenCommand[0] == "Filter" && givenCommand[1] == "<=")
                {
                    int conditionNumber = int.Parse(givenCommand[2]);
                    List<int> lessThanEqual = new List<int>(nums.Count);

                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] <= conditionNumber)
                        {
                            lessThanEqual.Add(nums[i]);
                        }
                    }

                    Console.WriteLine(string.Join(' ', lessThanEqual));

                }

                if ( givenCommand[0] == "Filter" && givenCommand[1] == ">")
                {
                    int conditionNumber = int.Parse(givenCommand[2]);
                    List<int> biggerNums = new List<int>(nums.Count);

                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] > conditionNumber)
                        {
                            biggerNums.Add(nums[i]);
                        }
                    }

                    Console.WriteLine(string.Join(' ', biggerNums));
                }

            }
        }

        static List<int> GetEvenNums(List<int> nums, int LengthOfNums)
        {
            List<int> even = new List<int>(LengthOfNums);

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    even.Add(nums[i]);
                }
            }

            return even;
        }        
            
        static List<int> GetOddNums(List<int> nums, int LengthOfNums)
        {
            List<int> odd = new List<int>(LengthOfNums);

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    odd.Add(nums[i]);
                }
            }

            return odd;
        }

        static int SumNumbers(List<int> sumNumbers)
        {
            int sum = 0;

            sum = sumNumbers.Sum();
            return sum;
        }

    }
}

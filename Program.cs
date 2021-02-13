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

                string action = givenCommand[0];  
                
                if (action == "Add")
                {
                    string number = givenCommand[1];
                    nums.Add(int.Parse(number));
                    actionCounter++;
                }

                if (action == "Remove")
                {
                    string number = givenCommand[1];
                    nums.Remove(int.Parse(number));
                    actionCounter++;
                }

                if (action == "RemoveAt")
                {
                    string number = givenCommand[1];
                    nums.RemoveAt(int.Parse(number));
                    actionCounter++;
                }

                if (action == "Insert")
                {
                    string index = givenCommand[2];
                    string number = givenCommand[1];
                    nums.Insert(int.Parse(index), int.Parse(number));
                    actionCounter++;
                }

                if (action == "Contains")
                {
                    string number = givenCommand[1];

                    if (nums.Contains(int.Parse(number)))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }

                if (action == "PrintEven")
                {
                    List<int> evenNumbers = GetEvenNums(nums, LengthOfNums);
                    Console.WriteLine(string.Join(" ", evenNumbers));
                }

                if (action == "PrintOdd")
                {
                    List<int> oddNumbers = GetOddNums(nums, LengthOfNums);
                    Console.WriteLine(string.Join(" ", oddNumbers));
                }

                if (action == "GetSum")
                {                    
                    int sumElements = SumNumbers(nums);
                    Console.WriteLine(sumElements);
                }                

                if (action == "Filter")
                {
                    string sign = givenCommand[1];
                    int termNum = int.Parse(givenCommand[2]);
                    GetNumsOnCondition(nums, sign, termNum);
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

        static List<int> GetNumsOnCondition(List<int> nums, string signCondition, int termNum) 
        {
            List<int> result = new List<int>(nums.Count);

            for (int i = 0; i < nums.Count; i++)
            {
                if (signCondition == "<" && nums[i] < termNum)
                {
                    result.Add(nums[i]);
                }
                else if ((signCondition == "<=" && nums[i] <= termNum))
                {
                    result.Add(nums[i]);
                }
                else if ((signCondition == ">" && nums[i] > termNum))
                {
                    result.Add(nums[i]);
                }
                else if ((signCondition == ">=" && nums[i] >= termNum))
                {
                    result.Add(nums[i]);
                }               
            }

            Console.WriteLine(string.Join(" ", result));
            return result;
        }
    }
}

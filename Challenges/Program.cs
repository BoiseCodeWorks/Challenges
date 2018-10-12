using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Challenges
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(GroceryQueue(new Queue<int>(new[] { 5, 3, 4 }), 2));
            Console.ReadLine();

            //var pairs = IcecreamParlor(new int[] { 3, 2, 5, 6, 5, 7, 5 }, 7);
            //pairs.ForEach(p =>
            //{
            //    if (p.Length > 1)
            //    {
            //        Console.WriteLine($"{p[0]} : {p[1]}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{p[0]}");
            //    }
            //});
            //Console.ReadLine();
        }

        private static int GroceryQueue(Queue<int> customers, int registers)
        {
            /**
             * Calculate the most efficient time possible to checkout all customers
             * given n registers
             * ([5,3,4], 1) == 12
             * ([10,2,3,3], 2) == 10
             * ([2,2,5,2,1], 3) == 5
             * here n=2 and the 2nd, 3rd, and 4th people in the queue 
             * finish before the 1st person.
             */

            //int time = 0;
            //var inUse = new List<int>();
            //var count = customers.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    if(i < registers)
            //    {
            //        inUse.Add(customers.Dequeue());
            //    }
            //    else
            //    {
            //        inUse[inUse.IndexOf(inUse.Min())] += customers.Dequeue();
            //    }
            //}
            ////return inUse.Max();

            //Dictionary<int, int> r = new Dictionary<int, int>();
            //var open = registers;

            //while (customers.Count > 0)
            //{
            //    customers.de
            //    var inUse = customers.Take(open);
            //    open = 0;
            //    for (int i = 0; i < registers; i++)
            //    {
            //        var register = inUse.ElementAtOrDefault(i);
            //        if (register != 0)
            //        {
            //            register--;
            //        }
            //        else
            //        {
            //            open++;
            //        }
            //    }
            //}

            var time = 0;
            var max = 0;
            while(customers.Count != 0)
            {
                var cTime = customers.Dequeue();
                time += cTime;
                if(cTime > max)
                {
                    max = cTime;
                }
            }
            return time / registers < max ? max : time / registers;







        }


        private static int[] RemoveDupes(int[] nums)
        {
            /**
             * SOLVE IN O(n)
             * [1,2,1,3,1,4,2,3,6] == [4,6]
             */

            var numberMap = new Dictionary<int, int>();
            var uniques = new HashSet<int>();

            foreach (var num in nums)
            {
                if (numberMap.ContainsKey(num))
                {
                    uniques.Remove(num);
                }
                else
                {
                    numberMap.Add(num, num);
                    uniques.Add(num);
                }
            }
            return uniques.ToArray();






        }


        private static List<int[]> IcecreamParlor(int[] menu, int cash)
        {
            /**
             * Solve in O(1)
             * [[0,5], [2,4] [2,6], [4,6]]
             * Chocolate: 3
             * Vanilla: 2
             * RockyRoad: 5
             * Praline: 6
             * RumRasin: 5
             * BaseballNut: 7
             * CookiesNCream: 5
             */
            var indexes = new Dictionary<int, List<int>>();
            var pairs = new List<int[]>();
            for (int i = 0; i < menu.Length; i++)
            {
                var scoopPrice = menu[i];
                var diff = cash - scoopPrice;
                if (diff == 0)
                {
                    pairs.Add(new int[1] { i });
                    continue;
                }
                if (indexes.ContainsKey(diff))
                {
                    var diffScoopTypes = indexes[diff];
                    for (int j = 0; j < diffScoopTypes.Count; j++)
                    {
                        var diffI = diffScoopTypes[j];
                        pairs.Add(new int[2] { i, diffI });
                    }
                }

                if (indexes.ContainsKey(scoopPrice))
                {
                    indexes[scoopPrice].Add(i);
                }
                else
                {
                    indexes.Add(scoopPrice, new List<int>() { i });
                }
            }
            return pairs;
        }


        private static bool BalancedBrackets(string code)
        {
            //SOLVE IN O(1)
            //([{}]) == true
            // {} == true
            // [} == false
            // ][ == false

            //code = Regex.Replace(code, "[A-z0-9 _]", "");
            //if(code.Length % 2 != 0)
            //{
            //    return false;
            //}

            //string half1 = code.Substring(0, (code.Length / 2) - 1);
            //string half2 = code.Substring(0, code.Length - 1);
            //return half1 == String.Join(half2.Split().Reverse().ToString(), "");

            var opens = new Stack<char>();
            var inverses = new Dictionary<char, char>();
            inverses.Add('[', ']');
            inverses.Add('{', '}');
            inverses.Add('(', ')');

            for (int i = 0; i < code.Length; i++)
            {
                var letter = code[i];
                switch (letter)
                {
                    case '(':
                    case '{':
                    case '[':
                        opens.Push(letter);
                        break;
                    case ')':
                    case '}':
                    case ']':
                        if (opens.Count == 0)
                        {
                            return false;
                        }
                        if (letter != inverses[opens.Pop()]) { return false; };
                        break;
                }
            }
            return opens.Count == 0;
        }


        private static int[] NeedleInHaystack(string str1, string str2)
        {
            //given a haystack and a needle find the indexes of each needle character in the haystack
            //rules you can only use the same letter once
            //str1 = hNaEysEtDLacEk, str2 = needle
            //output == [1,3,6,8,9,12]
            //if you get it can you do it in O(n) time complexity

            //var output = new List<int>();
            //var str1Arr = str1.ToArray();
            //for (int i = 0; i < str1Arr.Length; i++)
            //{
            //    var currChar = char.ToLower(str1Arr[i]);
            //    if (str2.Contains(currChar))
            //    {
            //        output.Add(i);
            //        str2.Remove(currChar);
            //    }
            //}
            //return output.ToArray();


            str1 = str1.ToUpper();
            str2 = str2.ToUpper();

            //int[] output = new int[str2.Length];
            //int[] letters = new int[26];
            //string[] positions = new string[26];
            //for (int i = 0; i < str1.Length; i++)
            //{
            //    var charNum = (int)str1[i] - 64;
            //}

            var charCount = 0;
            var output = new int[str2.Length];
            for (int i = 0; i < str1.Length; i++)
            {
                var currChar = str1[i];
                if (currChar == str2[charCount])
                {
                    output[charCount] = i;
                    charCount++;
                }
            }

            return charCount == str2.Length - 1 ? output : null;






        }

        private static void Kaperkar()
        {
            /**
             * Take any four-digit number, using at least two different digits. (Leading zeros are allowed.)
             * Arrange the digits in descending and then in ascending order to get two four-digit numbers, 
             * adding leading zeros if necessary.
             * Subtract the smaller number from the bigger number.
             * Go back to step 2 and repeat until the number becomes 6174
             * Max iterations will be 8 for any valid number
             */
            int KAPERKAR = 6174;
            int i = 0;
            string input = Console.ReadLine();
            int.TryParse(input, out int n);

            while (n != KAPERKAR)
            {
                string x = n.ToString();
                if (x.Length < 4)
                {
                    x = new string('0', 4 - x.Length) + x;
                }
                //do stuff
                i++;
                var smallS = x.ToCharArray().OrderBy(d => d);
                var largeS = x.ToCharArray().OrderByDescending(d => d);

                int.TryParse(String.Join("", smallS), out int small);
                int.TryParse(String.Join("", largeS), out int large);

                n = large - small;
            }
            Console.WriteLine($"Iterations: {i}");
            Console.ReadLine();

        }

        #region HasPair
        private static void HasPairRunner()
        {
            int[] nums = new int[10000000];
            int i = 0;
            Random r = new Random();
            int sum = 3000;
            while (i != nums.Length)
            {
                nums[i] = r.Next(0, 3000);
                i++;
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();
            System.Console.WriteLine(ArrayPair(nums, sum));
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            System.Console.WriteLine(elapsedMs);
            Console.ReadLine();
        }
        static HashSet<int> set = new HashSet<int>();
        static int[] f = new int[3000];
        private static bool BadPair(int[] nums, int sum)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var currentNum = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var nextNum = nums[j];
                    if (currentNum + nextNum == sum)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private static bool HasPair(int[] nums, int sum)
        {
            /**
             * Solve with O(1) time complexity
             * ValidPair([-1,2,5,18,8,14,22], 20) == true;
             * ValidPair([-1,2,13,1,2], 28) == false;
             */


            //River O(2)
            int lowbound = 0, highbound = nums.Length - 1;
            while (lowbound < highbound)
            {
                int low = nums[lowbound];
                int high = nums[highbound];

                if (low + high == sum)
                {
                    return true;
                }

                if (low + high > sum)
                {
                    highbound--;
                }
                if (low + high < sum)
                {
                    lowbound++;
                }
            }
            return false;
        }
        private static bool HashPair(int[] nums, int sum)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var dif = sum - nums[i];
                if (set.Contains(dif)) { return true; }
                set.Add(nums[i]);
            }
            return false;
        }
        private static bool ArrayPair(int[] nums, int sum)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var dif = sum - nums[i];
                if (f[dif] != 0) { return true; }
                f[nums[i]] = nums[i];
            }
            return false;
        }
        #endregion
    }
}

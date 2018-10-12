using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Challenges
{
    static class Pressure
    {
        
        public static int DoubleInteger(int num)
        {
            return num + num;
        }

        public static bool IsNumberEven(int num)
        {
            return num % 2 == 0;
        }

        public static string FileExtension(string str)
        {
            return Path.GetExtension(str);

            string[] strArr = str.Split('.');
            
            return strArr.Last();
            return strArr[strArr.Length - 1];

            var i = str.LastIndexOf('.');
            return str.Substring(i);


        }

        public static string LongestString(string[] strArray)
        {
            //return strArray.OrderByDescending(s => s.Length).First();

            var longstr = "";
            for (int i = 0; i < strArray.Length; i++)
            {
                var str = strArray[i];
                if(str.Length > longstr.Length)
                {
                    longstr = str;
                }
            }
            return longstr;
        }

        public static int SumAllInts(IEnumerable<int[]> nums)
        {
            return nums.Select(set => set.Sum()).Sum();
            //int sum = 0;
            //foreach(var set in nums)
            //{
            //    foreach(var num in set)
            //    {
            //        sum += num;
            //    }
            //}
            //return sum;
        }
    }
}


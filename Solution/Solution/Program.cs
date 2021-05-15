using System;
using System.Collections.Generic;


namespace Solution
{
        public class encoding
        {
            public string Ans(int nums)
            {
                Dictionary<int, char> encode = new Dictionary<int, char>();
                encode.Add(0, ' ');
                encode.Add(1, 'e');
                encode.Add(2, 't');
                encode.Add(3, 'a');
                encode.Add(4, 'o');
                encode.Add(5, 'i');
                encode.Add(6, 'n');
                encode.Add(7, 's');
                encode.Add(8, 'h');
                encode.Add(9, 'r');

                List<char> letters = new List<char>();
                int val = nums;
                while (val > 0)
                {
                    int rem = val % 10;
                    val = (int)val / 10;
                    if (encode.ContainsKey(rem))
                    { letters.Add(encode[rem]); }
                    else
                    { }
                }
                List<char> letters_rev = new List<char>();
                for(int i =0; i < letters.Count; i++)
                {
                    letters_rev.Add(letters[letters.Count - 1 - i]);
                }

                string answer = string.Join("", letters_rev.ToArray());
                Console.WriteLine(" Result is : " + answer);
                Console.ReadLine();
            return answer;
        }

            public static void Main(string[] args)
            {
                encoding obj = new encoding();
                obj.Ans(123123456);
            
        }
        }
}

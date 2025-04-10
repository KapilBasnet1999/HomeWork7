// Written By Kapil Basnet
// April 09, 2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public class HomeWork7
    {
        // 1. Maximum Number of Balloons
        public int MaxNumberOfBalloons(string text)
        {
            int[] freq = new int[26];
            for (int i = 0; i < text.Length; i++)
            {
                freq[text[i] - 'a']++;
            }

            int b = freq['b' - 'a'];
            int a = freq['a' - 'a'];
            int l = freq['l' - 'a'] / 2;
            int o = freq['o' - 'a'] / 2;
            int n = freq['n' - 'a'];

            int min = b;
            if (a < min) min = a;
            if (l < min) min = l;
            if (o < min) min = o;
            if (n < min) min = n;

            return min;
        }

        // 2. Robot Return to Origin
        public bool JudgeCircle(string moves)
        {
            int x = 0, y = 0;

            for (int i = 0; i < moves.Length; i++)
            {
                char move = moves[i];
                if (move == 'U') y++;
                else if (move == 'D') y--;
                else if (move == 'L') x--;
                else if (move == 'R') x++;
            }

            return x == 0 && y == 0;
        }

        // 3. Find the Difference
        public char FindTheDifference(string s, string t)
        {
            int[] count = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                count[s[i] - 'a']++;
            }

            for (int i = 0; i < t.Length; i++)
            {
                count[t[i] - 'a']--;
                if (count[t[i] - 'a'] < 0)
                {
                    return t[i];
                }
            }

            return ' '; // Default return, not expected
        }

        // 4. Merge Strings Alternately
        public string MergeAlternately(string word1, string word2)
        {
            char[] result = new char[word1.Length + word2.Length];
            int i = 0, j = 0, k = 0;

            while (i < word1.Length || j < word2.Length)
            {
                if (i < word1.Length)
                {
                    result[k] = word1[i];
                    i++; k++;
                }
                if (j < word2.Length)
                {
                    result[k] = word2[j];
                    j++; k++;
                }
            }

            string final = "";
            for (int x = 0; x < result.Length; x++)
            {
                final += result[x];
            }

            return final;
        }

        // 5. First Unique Character in a String
        public int FirstUniqChar(string s)
        {
            int[] freq = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                freq[s[i] - 'a']++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (freq[s[i] - 'a'] == 1)
                    return i;
            }

            return -1;
        }

        // 6. Number of Segments in a String
        public int CountSegments(string s)
        {
            int count = 0;
            bool inSegment = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    if (!inSegment)
                    {
                        count++;
                        inSegment = true;
                    }
                }
                else
                {
                    inSegment = false;
                }
            }

            return count;
        }
    }

}

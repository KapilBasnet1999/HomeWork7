namespace HomeWork7
{
    using System;

    class Program
    {
        public static void Main(string[] args)
        {
            HomeWork7 hw = new HomeWork7();

            // 1. Maximum Number of Balloons
            string text1 = "loonbalxballpoon";
            int balloons = hw.MaxNumberOfBalloons(text1);
            Console.WriteLine("1. Maximum Number of Balloons: " + balloons);

            // 2. Robot Return to Origin
            string moves = "UDLR";
            bool returned = hw.JudgeCircle(moves);
            Console.WriteLine("2. Robot Returned to Origin: " + returned);

            // 3. Find the Difference
            string s = "abcd";
            string t = "abcde";
            char diff = hw.FindTheDifference(s, t);
            Console.WriteLine("3. Difference in Strings: " + diff);

            // 4. Merge Strings Alternately
            string word1 = "abc";
            string word2 = "pqr";
            string merged = hw.MergeAlternately(word1, word2);
            Console.WriteLine("4. Merged Strings: " + merged);

            // 5. First Unique Character
            string input5 = "loveleetcode";
            int uniqueIndex = hw.FirstUniqChar(input5);
            Console.WriteLine("5. First Unique Character Index: " + uniqueIndex);

            // 6. Number of Segments
            string input6 = "Hello, my name is John";
            int segments = hw.CountSegments(input6);
            Console.WriteLine("6. Number of Segments: " + segments);
        }
    }

}

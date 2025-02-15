namespace CrackingLeetcode.lib
{
    /// <summary>
    /// 38. Count and Say
    /// 
    /// The count-and-say sequence is a sequence of digit strings defined by the recursive formula:

    ///    countAndSay(1) = "1"
    /// countAndSay(n) is the run-length encoding of countAndSay(n - 1).
    /// Run-length encoding(RLE) is a string compression method that works by replacing consecutive identical characters(repeated 2 or more times) with the concatenation of the character and the number marking the count of the characters(length of the run). For example, to compress the string "3322251" we replace "33" with "23", replace "222" with "32", replace "5" with "15" and replace "1" with "11". Thus the compressed string becomes "23321511".

    /// Given a positive integer n, return the nth element of the count-and-say sequence.
    ///
    /// Run-length encoding (RLE) is a string compression method that works by replacing consecutive identical characters (repeated 2 or more times) with the concatenation of the character and the number marking the count of the characters (length of the run). For example, to compress the string "3322251" we replace "33" with "23", replace "222" with "32", replace "5" with "15" and replace "1" with "11". Thus the compressed string becomes "23321511".

    /// Given a positive integer n, return the nth element of the count-and-say sequence.
    /// </summary>
    public class MediumCountAndSay
    {
        public static string CountAndSay(int n)
        {
            string current = "1"; 

            while (n-- - 1 > 0)
            {
                current = Encode(current);
            }

            return current;
        }

        private static string Encode(string input)
        {
            string encoded = string.Empty;

            char lastChar = input[0];

            int count = 1;

            foreach (char c in input.Substring(1))
            {
                if (c == lastChar)
                {
                    count++;
                }

                else
                {
                    encoded += count.ToString() + lastChar;

                    count = 1;
                    lastChar = c;
                }
            }

            encoded += count.ToString() + lastChar;

            count = 1;

            return encoded;
        }
    }
}

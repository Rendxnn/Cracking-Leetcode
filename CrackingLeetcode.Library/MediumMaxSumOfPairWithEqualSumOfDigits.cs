namespace CrackingLeetcode.Library
{
    public class MediumMaxSumOfPairWithEqualSumOfDigits
    {
        public static int MaximumSum(int[] nums)
        {
            int ans = -1;

            Dictionary<int, int> dic = [];

            for (int i = 0; i < nums.Length; i++)
            {
                int digitsSum = nums[i].ToString().Sum(c => Convert.ToInt16(c.ToString()));

                if (!dic.ContainsKey(digitsSum))
                {
                    dic[digitsSum] = nums[i];
                }

                else
                {
                    if (nums[i] + dic[digitsSum] > ans)
                    {
                        ans = nums[i] + dic[digitsSum];
                    }

                    if (dic[digitsSum] < nums[i])
                    {
                        dic[digitsSum] = nums[i];
                    }
                }
            }

            return ans;
        }
    }
}

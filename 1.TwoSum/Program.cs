namespace _1.TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = TwoSum(new[] { 3, 2 ,4}, 6);
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int pair = target - nums[i];
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (nums[j] == pair)
                    {
                        return new int[] {i, j};
                    }
                }
            }

            return null;
        }
    }
}
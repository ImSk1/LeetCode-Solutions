namespace _169.MajorityElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 }));
        }
        public static int MajorityElement(int[] nums)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            

            for (int i = 0; i < nums.Length; i++)
            {
                if (!counts.ContainsKey(nums[i]))
                {
                    counts.Add(nums[i], 1);
                }
                else
                {
                    counts[nums[i]]++;
                }
            }

            var maxVal = counts.Values.Max();
            return counts.First(k => k.Value == maxVal).Key;
        }
    }
}
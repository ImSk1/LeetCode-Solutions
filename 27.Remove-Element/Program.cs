namespace _27.Remove_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
        }
        //2 Pointers Method
        public static int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            int j = nums.Length - 1;

            int k = nums.Length;

            foreach (int num in nums)
            {
                if (num == val)
                {
                    k--;
                }
            }

            while (i < j)
            {
                if (nums[i] == val && nums[j] != val)
                {
                    (nums[j], nums[i]) = (nums[i], nums[j]);
                    i++;
                    j--;
                    
                }
                else if(nums[i] != val && nums[j] == val)
                {
                    i++;
                    j--;
                }
                else if (nums[i] == val && nums[j] == val)
                {
                    j--;
                }
                else if (nums[i] != val && nums[j] != val)
                {
                    i++;
                }
            }

            return k;
        }
    }
}
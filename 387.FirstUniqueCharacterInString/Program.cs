namespace _387.FirstUniqueCharacterInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static int FirstUniqChar(string s)
        {
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    dict[s[i]]++;
                }
                else
                {
                    dict.Add(s[i], 1);
                }
            }
            var sym = dict.FirstOrDefault(x => x.Value == 1);
            if (sym.Value == 0)
            {
                return -1;
            }

            return s.IndexOf(sym.Key);
        }
    }
}
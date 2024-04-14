namespace _1111410016_劉梓旋_032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> romanMap = new Dictionary<int, string>()
            {
            {1000, "M"}, {900, "CM"}, {500, "D"}, {400, "CD"},
            {100, "C"}, {90, "XC"}, {50, "L"}, {40, "XL"},
            {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"}, {1, "I"}
            };

            Console.WriteLine("Please enter a number: ");
            int num = int.Parse(Console.ReadLine());

            string answer = "";

            foreach (var kvp in romanMap)
            {
                int value = kvp.Key;
                string symbol = kvp.Value;

                while (num >= value)
                {
                    answer += symbol;
                    num -= value;
                }
            }

            Console.WriteLine(answer);
        }
    }
}

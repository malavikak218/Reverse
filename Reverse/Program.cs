namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "MALAVIKA";
            char[] charArray = new char[input.Length];
            int j = input.Length - 1;

            for (int i = 0; i < input.Length; i++)
            {
                charArray[i] = input[j];
                j--;
            }

            string reversed = new string(charArray);
            Console.WriteLine(reversed);
        }
    }
}
 
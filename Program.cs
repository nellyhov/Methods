namespace Methods
{
    internal class Program
    {

        public static void CalculateBiggestElementInArray() {
            int[] arrayOfNumbers = {2, 100, 66, 8, 12, 999};
            int maxNumber = arrayOfNumbers.Max();
            Console.WriteLine(maxNumber);
            }
        static void Main(string[] args)
        {
            CalculateBiggestElementInArray();
        }
    }
}

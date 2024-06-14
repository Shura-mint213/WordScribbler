using NumberToText.Extensions;

namespace ConsoleAppTest
{
    /// <summary>
    /// основной класс для этого консольного приложения 
    /// </summary>
    internal class Program
    {

        /// <summary>
        /// основная точка входа для этого консольного приложения 
        /// </summary>
        /// <param name="args">A string array of arguments passed 
        /// to the console app.</param>
        private static void Main(string[] args)
        {
            int number = -125_500_024;

            string value = number.ConvertNumberToText();
            Console.WriteLine(value);
        }
    }
}
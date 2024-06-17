using NumberToText.Core;
using NumberToText.Extensions;
using NumberToText.Shared.Enum;

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
            WordDeclension wordDeclension = new();

            //// Склоняем слово "озеро" в родительный падеж
            //string word = "ноч";
            //Padezh padezh = Padezh.Genitive;

            //string declinedWord = wordDeclension.DeclineWord(word, padezh);

            //Console.WriteLine(declinedWord); // Вывод: "озера"

            //// Склоняем слово "море" в творительный падеж
            //word = "домами";
            //padezh = Padezh.Genitive;

            //declinedWord = wordDeclension.DeclineWord(word, padezh);

            //Console.WriteLine(declinedWord); // Вывод: "морем"
            int number = -125_500_024;

            string value = number.ConvertNumberToText();
            Console.WriteLine(value);

            var numberText = wordDeclension.DeclineWords(value, Padezh.Genitive);

            Console.WriteLine(numberText);
        }
    }
}
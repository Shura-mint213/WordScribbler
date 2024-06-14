using NumberToText.Core;
using NumberToText.Shared.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace NumberToText.Extensions
{
    public static class NumericExtension
    {
        /// <summary>
        /// Подсчет количества цифр в целочисленном числе
        /// </summary>
        /// <typeparam name="T">Тип данных числа</typeparam>
        /// <param name="digits">Число</param>
        /// <returns>Количество цифр в числе</returns>
        /// <exception cref="ArgumentException">Выбрасывается если тип данных 
        /// переданного числа не поддерживается</exception>
        private static sbyte CountDigitsOfIntegerNumber<T>(T digits) where T : struct
        {
            sbyte digistsCount = 0;
            
            double log10 = Math.Log10(Convert.ToDouble(digits));
            digistsCount = (sbyte)(Math.Floor(log10) + 1);
            

            return digistsCount;
        }

        /// <summary>
        /// Написание числа прописью
        /// </summary>
        /// <typeparam name="T">Тип данных числа</typeparam>
        /// <param name="value">Число</param>
        /// <returns>Пропись числа</returns>
        /// <exception cref="ArgumentException">Выбрасывается если тип данных 
        /// переданного числа не поддерживается</exception>
        public static string ConvertNumberToText<T>(this T value) where T : struct
        {
            NumberToWord numberToWord = new();
            if (value is IConvertible || value is decimal)
            {
                return numberToWord.IntegerNumberInWords(value);
            }
            else
            {
                throw new ArgumentException("Тип не поддерживается.");
            }
        }
    }
}

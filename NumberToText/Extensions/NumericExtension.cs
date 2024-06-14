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
        private static readonly string[] _units = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять", "одинадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать", };
        private static readonly string[] _tens = { "", "", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
        private static readonly string[] _hundreds = { "", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот" };
        //private static readonly string[] _thousands = { "", "тысяча", "тысячи", "тысяч" };
        //private static readonly string[] _millions = { "", "миллион", "миллиона", "милионов" };
        //private static readonly string[] _billions = { "", "миллиард", "миллиарда", "миллиардов" };
        //private static readonly string[] _trillions = { "", "триллион", "триллиона", "триллионов", };
        //private static readonly string[] _kvadrillions = { "", "квадриллион", "квадриллиона", "квадриллионов", };
        private const string _thousand = "тысяча";
        private const string _million = "миллион";
        private const string _billion = "миллиард";
        private const string _trillion = "триллион";
        private const string _kvadrillion = "квадриллион";
        private static readonly Dictionary<sbyte, string> _numberOfDigitsInWords = new()
        {
            { 4, _thousand },
            { 5, _million },
            { 6, _billion },
            { 7, _trillion },
            { 8, _kvadrillion },
        };

        /// <summary>
        /// Подсчет количества цифр в целочисленном числе
        /// </summary>
        /// <typeparam name="T">Тип данных числа</typeparam>
        /// <param name="digits">Число</param>
        /// <returns>Количество цифр в числе</returns>
        /// <exception cref="ArgumentException">Тип не поддерживается</exception>
        private static sbyte CountDigitsOfIntegerNumber<T>(T digits) where T : struct
        {
            sbyte digistsCount = 0;
            
            double log10 = Math.Log10(Convert.ToDouble(digits));
            digistsCount = (sbyte)(Math.Floor(log10) + 1);
            

            return digistsCount;
        }

        private static string ProcessGroup(long number)
        {
            StringBuilder sb = new StringBuilder();
            
            if (number >= 100)
            {
                long hundred = number / 100;
                if (hundred > 1)
                {
                    sb.Append(NumberToWordsResources.Ones[hundred]);
                }
                sb.Append(NumberToWordsResources.Handreds[hundred]);
                sb.Append(" ");
                number %= 100;
            }

            if (number >= 20)
            {
                sb.Append(NumberToWordsResources.Tens[number / 10]);
                sb.Append(" ");
                number %= 10;
            }
            else if (number >= 10)
            {
                sb.Append(NumberToWordsResources.Teens[number - 10]);
                sb.Append(" ");
                number = 0;
            }

            if (number > 0)
            {
                sb.Append(NumberToWordsResources.Ones[number]);
                sb.Append(" ");
            }

            return sb.ToString();

        }

        private static string IntegerNumberInWords<T>(T num) where T : struct
        {
            long number = Convert.ToInt64(num);
            
            if (number == 0)
            {
                return NumberToWordsResources.Ones[number];
            }

            if (number < 0)
            {
                return "минус " + IntegerNumberInWords(-number);
            }

            StringBuilder words = new StringBuilder();
            int groupIndex = 0;

            while (number > 0)
            {
                if (number % 1000 != 0)
                {
                    words.Insert(0, 
                        $"{ProcessGroup(number % 1000)} {NumberToWordsResources.Thousands[groupIndex]} ");
                }
                number /= 1000;
                groupIndex++;
            }

            return words.ToString();
        }

        public static string ConvertNumberToText<T>(this T value) where T : struct
        {
            if (value is IConvertible || value is decimal)
            {
                //sbyte numberOfDigits = CountDigitsOfIntegerNumber(value);

                return IntegerNumberInWords(value);
            }
            else
            {
                throw new ArgumentException("Тип не поддерживается.");
            }
        }
    }
}

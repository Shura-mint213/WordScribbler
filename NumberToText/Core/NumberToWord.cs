using NumberToText.Shared.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToText.Core
{
    internal class NumberToWord
    {
        /// <summary>
        /// Образует группу из 3 цифр (единыцы, десятки, сотни).
        /// </summary>
        /// <param name="number">Число в пределах от 0 до 999.</param>
        /// <returns>Строка, представляющая число в прописи.</returns>
        private string ProcessGroup(long number)
        {
            StringBuilder sb = new StringBuilder();
            // Обработка сотен
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
            // Обработка десятков и единиц
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

            // Обработка единиц
            if (number > 0)
            {
                sb.Append(NumberToWordsResources.Ones[number]);
                sb.Append(" ");
            }

            return sb.ToString();

        }

        /// <summary>
        /// Преобразует целое число в пропись.
        /// </summary>
        /// <typeparam name="T">Тип данных числа.</typeparam>
        /// <param name="num">Целое число которое нужно преобразовать.</param>
        /// <returns>Строка, представляющая число в прописи.</returns>
        public string IntegerNumberInWords<T>(T num) where T : struct
        {
            long number = Convert.ToInt64(num);
            // Проверяем на ноль
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
            // Проход по группам по 3 цифры (единицы, тысячи, миллионы и т.д.)
            while (number > 0)
            {
                // Если группа не равна 0 обрабатываем её
                if (number % 1000 != 0)
                {
                    words.Insert(0,
                        $"{ProcessGroup(number % 1000)} {NumberToWordsResources.Thousands[groupIndex]} ");
                }
                // Переходим к следующей группе
                number /= 1000;
                groupIndex++;
            }

            return words.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToText.Shared.Static
{
    /// <summary>
    /// Слова соответствующие цифрам
    /// </summary>
    internal static class NumberToWordsResources
    {
        internal static readonly string[] Ones = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
        internal static readonly string[] Teens = { "десять", "одинадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
        internal static readonly string[] Tens = { "", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
        internal static readonly string[] Handreds = { "", "сто", "сти", "ста", "сто", "сот", "сот", "сот", "сот", "сот" };
        internal readonly static string[] Thousands = { "", "тысяча", "миллион", "миллиард", "триллион", "квадриллион", "квинтиллион", "секстиллион", "септиллион", "октиллион", "нониллион", "дециллион" };
    }
}

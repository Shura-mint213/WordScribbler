using NumberToText.Shared.Enum;
using NumberToText.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToText.Shared.Static
{
    internal static class EndingsOfWords
    {
        /// <summary>
        /// Словарь окончаний всех склонений множественного числа
        /// </summary>
            internal static readonly Dictionary<Skloneniye, string[]> DeclensionEndings = new Dictionary<Skloneniye, string[]>
            {
                { Skloneniye.First, new string[] { "ы", "и", "ов", "ам", "ами", "ах" } },
                { Skloneniye.Second, new string[] { "ы", "и", "ов", "ей", "ам", "ами", "ах" } },
                { Skloneniye.Third, new string[] { "и", "ей", "ям", "ями", "ях" } }
            };

        /// <summary>
        /// Список окончаний
        /// </summary>
        internal static readonly Dictionary<(Skloneniye, NumberForm, Padezh, Gender), string> Endings = new Dictionary<(Skloneniye, NumberForm, Padezh, Gender), string>
        {
            // Первое склонение (женский род)
            {(Skloneniye.First, NumberForm.Singular, Padezh.Nominative, Gender.Feminine), "а"},
            {(Skloneniye.First, NumberForm.Singular, Padezh.Genitive, Gender.Feminine), "ы"},
            {(Skloneniye.First, NumberForm.Singular, Padezh.Dative, Gender.Feminine), "е"},
            {(Skloneniye.First, NumberForm.Singular, Padezh.Accusative, Gender.Feminine), "у"},
            {(Skloneniye.First, NumberForm.Singular, Padezh.Instrumental, Gender.Feminine), "ой"},
            {(Skloneniye.First, NumberForm.Singular, Padezh.Prepositional, Gender.Feminine), "е"},

            {(Skloneniye.First, NumberForm.Plural, Padezh.Nominative, Gender.Feminine), "ы"},
            {(Skloneniye.First, NumberForm.Plural, Padezh.Genitive, Gender.Feminine), "ы"},
            {(Skloneniye.First, NumberForm.Plural, Padezh.Dative, Gender.Feminine), "ам"},
            {(Skloneniye.First, NumberForm.Plural, Padezh.Accusative, Gender.Feminine), "ы"},
            {(Skloneniye.First, NumberForm.Plural, Padezh.Instrumental, Gender.Feminine), "ами"},
            {(Skloneniye.First, NumberForm.Plural, Padezh.Prepositional, Gender.Feminine), "ах"},
        
            // Второе склонение (мужской род)
            {(Skloneniye.Second, NumberForm.Singular, Padezh.Nominative, Gender.Masculine), ""},
            {(Skloneniye.Second, NumberForm.Singular, Padezh.Genitive, Gender.Masculine), "а"},
            {(Skloneniye.Second, NumberForm.Singular, Padezh.Dative, Gender.Masculine), "у"},
            {(Skloneniye.Second, NumberForm.Singular, Padezh.Accusative, Gender.Masculine), ""},
            {(Skloneniye.Second, NumberForm.Singular, Padezh.Instrumental, Gender.Masculine), "ом"},
            {(Skloneniye.Second, NumberForm.Singular, Padezh.Prepositional, Gender.Masculine), "е"},

            {(Skloneniye.Second, NumberForm.Plural, Padezh.Nominative, Gender.Masculine), "ы"},
            {(Skloneniye.Second, NumberForm.Plural, Padezh.Genitive, Gender.Masculine), "ов"},
            {(Skloneniye.Second, NumberForm.Plural, Padezh.Dative, Gender.Masculine), "ам"},
            {(Skloneniye.Second, NumberForm.Plural, Padezh.Accusative, Gender.Masculine), "ы"},
            {(Skloneniye.Second, NumberForm.Plural, Padezh.Instrumental, Gender.Masculine), "ами"},
            {(Skloneniye.Second, NumberForm.Plural, Padezh.Prepositional, Gender.Masculine), "ах"},
        
            // Второе склонение (средний род)
            {(Skloneniye.Second, NumberForm.Singular, Padezh.Nominative, Gender.Neuter), "о"},
            {(Skloneniye.Second, NumberForm.Singular, Padezh.Genitive, Gender.Neuter), "а"},
            {(Skloneniye.Second, NumberForm.Singular, Padezh.Dative, Gender.Neuter), "у"},
            {(Skloneniye.Second, NumberForm.Singular, Padezh.Accusative, Gender.Neuter), "о"},
            {(Skloneniye.Second, NumberForm.Singular, Padezh.Instrumental, Gender.Neuter), "ом"},
            {(Skloneniye.Second, NumberForm.Singular, Padezh.Prepositional, Gender.Neuter), "е"},

            {(Skloneniye.Second, NumberForm.Plural, Padezh.Nominative, Gender.Neuter), "а"},
            {(Skloneniye.Second, NumberForm.Plural, Padezh.Genitive, Gender.Neuter), "ов"},
            {(Skloneniye.Second, NumberForm.Plural, Padezh.Dative, Gender.Neuter), "ам"},
            {(Skloneniye.Second, NumberForm.Plural, Padezh.Accusative, Gender.Neuter), "а"},
            {(Skloneniye.Second, NumberForm.Plural, Padezh.Instrumental, Gender.Neuter), "ами"},
            {(Skloneniye.Second, NumberForm.Plural, Padezh.Prepositional, Gender.Neuter), "ах"},
        
            // Третье склонение (женский род на мягкий знак)
            {(Skloneniye.Third, NumberForm.Singular, Padezh.Nominative, Gender.Feminine), "ь"},
            {(Skloneniye.Third, NumberForm.Singular, Padezh.Genitive, Gender.Feminine), "и"},
            {(Skloneniye.Third, NumberForm.Singular, Padezh.Dative, Gender.Feminine), "и"},
            {(Skloneniye.Third, NumberForm.Singular, Padezh.Accusative, Gender.Feminine), "ь"},
            {(Skloneniye.Third, NumberForm.Singular, Padezh.Instrumental, Gender.Feminine), "ью"},
            {(Skloneniye.Third, NumberForm.Singular, Padezh.Prepositional, Gender.Feminine), "и"},

            {(Skloneniye.Third, NumberForm.Plural, Padezh.Nominative, Gender.Feminine), "и"},
            {(Skloneniye.Third, NumberForm.Plural, Padezh.Genitive, Gender.Feminine), "ей"},
            {(Skloneniye.Third, NumberForm.Plural, Padezh.Dative, Gender.Feminine), "ям"},
            {(Skloneniye.Third, NumberForm.Plural, Padezh.Accusative, Gender.Feminine), "и"},
            {(Skloneniye.Third, NumberForm.Plural, Padezh.Instrumental, Gender.Feminine), "ями"},
            {(Skloneniye.Third, NumberForm.Plural, Padezh.Prepositional, Gender.Feminine), "ях"}
        };
    }
}

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
        internal static readonly Dictionary<(Skloneniye, NumberForm, Padezh), string> Endings = new Dictionary<(Skloneniye, NumberForm, Padezh), string>
        {
            // First declension singular
            {(Skloneniye.First, NumberForm.Singular, Padezh.Nominative), ""},
            {(Skloneniye.First, NumberForm.Singular, Padezh.Genitive), "ы"},
            {(Skloneniye.First, NumberForm.Singular, Padezh.Dative), "е"},
            {(Skloneniye.First, NumberForm.Singular, Padezh.Accusative), "у"},
            {(Skloneniye.First, NumberForm.Singular, Padezh.Instrumental), "ой"},
            {(Skloneniye.First, NumberForm.Singular, Padezh.Prepositional), "е"},
        
            // First declension plural
            {(Skloneniye.First, NumberForm.Plural, Padezh.Nominative), "ы"},
            {(Skloneniye.First, NumberForm.Plural, Padezh.Genitive), ""},
            {(Skloneniye.First, NumberForm.Plural, Padezh.Dative), "ам"},
            {(Skloneniye.First, NumberForm.Plural, Padezh.Accusative), ""},
            {(Skloneniye.First, NumberForm.Plural, Padezh.Instrumental), "ами"},
            {(Skloneniye.First, NumberForm.Plural, Padezh.Prepositional), "ах"},
        
            // Second declension singular
            {(Skloneniye.Second, NumberForm.Singular, Padezh.Nominative), ""},
            {(Skloneniye.Second, NumberForm.Singular, Padezh.Genitive), "а"},
            {(Skloneniye.Second, NumberForm.Singular, Padezh.Dative), "у"},
            {(Skloneniye.Second, NumberForm.Singular, Padezh.Accusative), ""},
            {(Skloneniye.Second, NumberForm.Singular, Padezh.Instrumental), "ом"},
            {(Skloneniye.Second, NumberForm.Singular, Padezh.Prepositional), "е"},
        
            // Second declension plural
            {(Skloneniye.Second, NumberForm.Plural, Padezh.Nominative), "ы"},
            {(Skloneniye.Second, NumberForm.Plural, Padezh.Genitive), "ов"},
            {(Skloneniye.Second, NumberForm.Plural, Padezh.Dative), "ам"},
            {(Skloneniye.Second, NumberForm.Plural, Padezh.Accusative), "ы"},
            {(Skloneniye.Second, NumberForm.Plural, Padezh.Instrumental), "ами"},
            {(Skloneniye.Second, NumberForm.Plural, Padezh.Prepositional), "ах"},
        
            // Third declension singular
            {(Skloneniye.Third, NumberForm.Singular, Padezh.Nominative), ""},
            {(Skloneniye.Third, NumberForm.Singular, Padezh.Genitive), "и"},
            {(Skloneniye.Third, NumberForm.Singular, Padezh.Dative), "и"},
            {(Skloneniye.Third, NumberForm.Singular, Padezh.Accusative), "ь"},
            {(Skloneniye.Third, NumberForm.Singular, Padezh.Instrumental), "ью"},
            {(Skloneniye.Third, NumberForm.Singular, Padezh.Prepositional), "и"},
        
            // Third declension plural
            {(Skloneniye.Third, NumberForm.Plural, Padezh.Nominative), "и"},
            {(Skloneniye.Third, NumberForm.Plural, Padezh.Genitive), "ей"},
            {(Skloneniye.Third, NumberForm.Plural, Padezh.Dative), "ям"},
            {(Skloneniye.Third, NumberForm.Plural, Padezh.Accusative), "и"},
            {(Skloneniye.Third, NumberForm.Plural, Padezh.Instrumental), "ями"},
            {(Skloneniye.Third, NumberForm.Plural, Padezh.Prepositional), "ях"}
        };
    }
}

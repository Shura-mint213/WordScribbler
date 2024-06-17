using NumberToText.Shared.Enum;
using NumberToText.Shared.Models;
using NumberToText.Shared.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static NumberToText.Shared.Static.EndingsOfWords;

namespace NumberToText.Core
{
    public class WordDeclension
    {
        public string DeclineWords(string words, Padezh padezh = Padezh.Nominative)
        {
            string[] wordsArr = Regex.Split(words, @"[^а-яА-ЯёЁ]+")
                .Where(word => !string.IsNullOrEmpty(word)) // Убираем пустые строки
                .Select(word => word.Trim()) // Удаляем пробельные символы в конце и начале
                .ToArray();

            return DeclineWords(wordsArr, padezh);
        }

        
        private string DeclineWords(string[] words, Padezh padezh)
        {
            StringBuilder sb = new();
            // Перебираем слова
            foreach (string word in words)
            {
                sb.Append(DeclineWord(word, padezh));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Склоняет слово в заданный падеж.
        /// </summary>
        /// <param name="word">Слово, которое нужно склонить.</param>
        /// <param name="padezh">Падеж, в который нужно склонить слово.</param>
        /// <returns>Склоненное слово.</returns>
        public string DeclineWord(string word, Padezh padezh)
        {
            var model = DetermineModel(word);
            if (model == null)
            {
                return word; // Если модель не определена, вернуть исходное слово
            }

            model.Padezh = padezh;

            return ReplaceEnding(word, model);
        }

        /// <summary>
        /// Определяет модель слова для склонения, включая окончание, число и склонение.
        /// </summary>
        /// <param name="word">Слово, для которого нужно определить модель.</param>
        /// <returns>Модель слова для склонения или null, если не удалось определить модель.</returns>

        private WordModelForDeclension DetermineModel(string word)
        {
            WordModelForDeclension model = new WordModelForDeclension();

            // Определения числа (упрощенно)
            if (IsDeclensionPlural(word, out string ending))
            {
                // Определения рода и склонения для множественного числа
                model.Ending = ending;
                model.NumberForm = NumberForm.Plural;

                // Дополнительная логика для определения склонения в множественном числе
                if (IsThirdDeclensionPlural(word))
                {
                    model.Skloneniye = Skloneniye.Third;
                }
                else if (IsFirstDeclensionPlural(word))
                {
                    model.Skloneniye = Skloneniye.First;
                }
                else
                {
                    model.Skloneniye = Skloneniye.Second;
                }

                return model;
            }

            // Первое склонение (существительные женского рода на -а, -я) иминительного падежа
            if (word.EndsWith("а"))
            {
                model.Ending = "а";
                model.NumberForm = NumberForm.Singular;
                model.Skloneniye = Skloneniye.First;
                return model;
            }

            if (word.EndsWith("я"))
            {
                model.Ending = "я";
                model.NumberForm = NumberForm.Singular;
                model.Skloneniye = Skloneniye.First;
                return model;
            }

            // Второе склонение (существительные мужского рода на твердый согласный, -о, -е) иминительного падежа
            if (word.EndsWith("о") || word.EndsWith("е"))
            {
                model.Ending = word.EndsWith("о") ? "о" : "е";
                model.NumberForm = NumberForm.Singular;
                model.Skloneniye = Skloneniye.Second;
                return model;
            }

            if (word.EndsWith("й") || word.EndsWith("ь"))
            {
                model.Ending = word.EndsWith("й") ? "й" : "ь";
                model.NumberForm = NumberForm.Singular;
                model.Skloneniye = Skloneniye.Second;
                return model;
            }

            // Третье склонение (существительные женского рода на мягкий знак) иминительного падежа
            if (word.EndsWith("ь") && IsFeminine(word))
            {
                model.Ending = "ь";
                model.NumberForm = NumberForm.Singular;
                model.Skloneniye = Skloneniye.Third;
                return model;
            }            

            // Если не удалось определить склонение, число и род
            return null;
        }

        /// <summary>
        /// Заменяет окончание в слове на новое.
        /// </summary>
        /// <param name="word">Слово, в котором нужно заменить окончание.</param>
        /// <param name="model">Модель окончания, на которое нужно заменить.</param>
        /// <returns>Слово с измененным окончанием.</returns>
        private string ReplaceEnding(string word, WordModelForDeclension model)
        {
            string root = word.Substring(0, word.Length - model.Ending.Length);
            if (Endings.TryGetValue((model.Skloneniye, model.NumberForm, model.Padezh), out string newEnding))
            {
                return root + newEnding;
            }
            return word; // Если окончание не найдено, вернуть исходное слово
        }

        /// <summary>
        /// Определяет, является ли слово женского рода.
        /// </summary>
        /// <param name="word">Слово для проверки.</param>
        /// <returns>True, если слово является женского рода;
        /// в противном случае — False.</returns>
        private bool IsFeminine(string word)
        {
            // Упрощенная логика для определения женского рода
            // В реальности потребуется более сложный анализ
            // Например, можно использовать словари или базы данных
            return word.EndsWith("ь") && word.Length > 1 && IsVowel(word[word.Length - 2]);
        }

        /// <summary>
        /// Определяет, является ли буква гласной.
        /// </summary>
        /// <param name="c">Буква для проверки.</param>
        /// <returns>True, если буква является гласной;
        /// в противном случае — False.</returns>
        private bool IsVowel(char c)
        {
            return "аеёиоуыэюя".IndexOf(c) >= 0;
        }

        /// <summary>
        /// Определяет, является ли слово множественным числом.
        /// </summary>
        /// <param name="word">Слово для проверки.</param>
        /// <param name="ending">Окончание слова.</param>
        /// <returns>True, если слово является множественным числом;
        /// в противном случае — False.</returns>
        private bool IsDeclensionPlural(string word, out string ending)
        {
            HashSet<string> endingsWords = new HashSet<string>();

            foreach (var endings in DeclensionEndings.Values)
            {
                endingsWords.UnionWith(endings.Where(ending => ending.Length == 3));
                endingsWords.UnionWith(endings.Where(ending => ending.Length == 2));
                endingsWords.UnionWith(endings.Where(ending => ending.Length == 1));
            }

            ending = endingsWords.FirstOrDefault(word.EndsWith);

            return ending != null;
        }

        /// <summary>
        /// Определяет, является ли слово множественным числом третьего склонения.
        /// </summary>
        /// <param name="word">Слово для проверки.</param>
        /// <returns>True, если слово является множественным числом третьего склонения;
        /// в противном случае — False.</returns>
        private bool IsThirdDeclensionPlural(string word)
        {
            // Проверяем, заканчивается ли слово одним из окончаний
            return DeclensionEndings.TryGetValue(Skloneniye.Third, out var value)
                && value.Any(word.EndsWith);
        }

        /// <summary>
        /// Определяет, является ли слово множественным числом первого склонения.
        /// </summary>
        /// <param name="word">Слово для проверки.</param>
        /// <returns>True, если слово является множественным числом первого склонения;
        /// в противном случае — False.</returns>
        private bool IsFirstDeclensionPlural(string word)
        {
            // Проверяем, заканчивается ли слово одним из окончаний
            return DeclensionEndings.TryGetValue(Skloneniye.First, out var value)
                && value.Any(word.EndsWith);
        }
    }
}

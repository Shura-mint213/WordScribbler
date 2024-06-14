using NumberToText.Shared.Enum;
using NumberToText.Shared.Models;
using NumberToText.Shared.Static;
using System;
using System.Collections.Generic;
using System.Linq;
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
            // Определяем склонение и форму числа слова
            WordModelForDeclension currentEndingModel = FindEnding(word);

            // Если окончание не найдено, возвращаем исходное слово
            if (currentEndingModel == null)
            {
                return word;
            }

            // Создаем новую модель окончания с заданным падежом
            WordModelForDeclension newEndingModel = new WordModelForDeclension
            {
                Skloneniye = currentEndingModel.Skloneniye,
                Padezh = padezh,
                NumberForm = currentEndingModel.NumberForm
            };

            // Склоняем слово
            return DeclineWord(word, newEndingModel); // Рекурсивно вызываем метод с новой моделью окончания
        }

        /// <summary>
        /// Находит окончание в слове.
        /// </summary>
        /// <param name="word">Слово, в котором нужно найти окончание.</param>
        /// <returns>Модель окончания, если она найдена, иначе null.</returns>
        private WordModelForDeclension FindEnding(string word)
        {
            // Проверяем, есть ли в словаре модели для окончаний
            foreach (var endingModel in EndingModels)
            {
                // Проверяем, есть ли окончание в слове
                if (word.EndsWith(endingModel.Ending))
                {
                    // Возвращаем модель окончания
                    return endingModel;
                }
            }

            // Окончание не найдено
            return null;
        }

        /// <summary>
        /// Заменяет окончание в слове на новое.
        /// </summary>
        /// <param name="word">Слово, в котором нужно заменить окончание.</param>
        /// <param name="newEnding">Новое окончание.</param>
        /// <param name="endingModel">Модель окончания, которое нужно заменить.</param>
        /// <returns>Слово с измененным окончанием.</returns>
        private string ReplaceEnding(string word, string newEnding, WordModelForDeclension endingModel)
        {
            // Удаляем старое окончание
            string wordWithoutEnding = word.Substring(0, word.Length - endingModel.Ending.Length);

            // Добавляем новое окончание
            return wordWithoutEnding + newEnding;
        }

        /// <summary>
        /// Склоняет слово в заданный падеж, используя модель окончания.
        /// </summary>
        /// <param name="word">Слово, которое нужно склонить.</param>
        /// <param name="newEndingModel">Модель окончания, которую нужно применить к слову.</param>
        /// <returns>Склоненное слово.</returns>
        private string DeclineWord(string word, WordModelForDeclension newEndingModel)
        {
            // Находим подходящее окончание из списка
            var currentEnding = EndingModels.FirstOrDefault(
                x => x.Skloneniye == newEndingModel.Skloneniye &&
                     x.Padezh == newEndingModel.Padezh &&
                     x.NumberForm == newEndingModel.NumberForm
            );

            if (currentEnding != null)
            {
                // Заменяем окончание
                return ReplaceEnding(word, newEndingModel.Ending, currentEnding);
            }
            else
            {
                // Не найдено подходящего окончания, возвращаем исходное слово
                return word;
            }
        }
    }
}

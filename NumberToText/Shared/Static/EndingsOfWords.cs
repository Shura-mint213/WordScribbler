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
        // Список окончаний
        internal static readonly List<WordModelForDeclension> EndingModels = new List<WordModelForDeclension>()
        {
            // Первое склонение
            new WordModelForDeclension { Ending = "", Skloneniye = Skloneniye.First, Padezh = Padezh.Nominative, NumberForm = NumberForm.Singular },
            new WordModelForDeclension { Ending = "а", Skloneniye = Skloneniye.First, Padezh = Padezh.Genitive, NumberForm = NumberForm.Singular },
            new WordModelForDeclension { Ending = "е", Skloneniye = Skloneniye.First, Padezh = Padezh.Dative, NumberForm = NumberForm.Singular },
            new WordModelForDeclension { Ending = "у", Skloneniye = Skloneniye.First, Padezh = Padezh.Accusative, NumberForm = NumberForm.Singular },
            new WordModelForDeclension { Ending = "ой", Skloneniye = Skloneniye.First, Padezh = Padezh.Instrumental, NumberForm = NumberForm.Singular },
            new WordModelForDeclension { Ending = "е", Skloneniye = Skloneniye.First, Padezh = Padezh.Prepositional, NumberForm = NumberForm.Singular },
            new WordModelForDeclension { Ending = "ы", Skloneniye = Skloneniye.First, Padezh = Padezh.Nominative, NumberForm = NumberForm.Plural },
            new WordModelForDeclension { Ending = "ов", Skloneniye = Skloneniye.First, Padezh = Padezh.Genitive, NumberForm = NumberForm.Plural },
            new WordModelForDeclension { Ending = "ам", Skloneniye = Skloneniye.First, Padezh = Padezh.Dative, NumberForm = NumberForm.Plural },
            new WordModelForDeclension { Ending = "ов", Skloneniye = Skloneniye.First, Padezh = Padezh.Accusative, NumberForm = NumberForm.Plural },
            new WordModelForDeclension { Ending = "ами", Skloneniye = Skloneniye.First, Padezh = Padezh.Instrumental, NumberForm = NumberForm.Plural },
            new WordModelForDeclension { Ending = "ах", Skloneniye = Skloneniye.First, Padezh = Padezh.Prepositional, NumberForm = NumberForm.Plural },

            // Второе склонение
            new WordModelForDeclension { Ending = "", Skloneniye = Skloneniye.Second, Padezh = Padezh.Nominative, NumberForm = NumberForm.Singular },
            new WordModelForDeclension { Ending = "а", Skloneniye = Skloneniye.Second, Padezh = Padezh.Genitive, NumberForm = NumberForm.Singular },
            new WordModelForDeclension { Ending = "у", Skloneniye = Skloneniye.Second, Padezh = Padezh.Dative, NumberForm = NumberForm.Singular },
            new WordModelForDeclension { Ending = "а", Skloneniye = Skloneniye.Second, Padezh = Padezh.Accusative, NumberForm = NumberForm.Singular },
            new WordModelForDeclension { Ending = "ом", Skloneniye = Skloneniye.Second, Padezh = Padezh.Instrumental, NumberForm = NumberForm.Singular },
            new WordModelForDeclension { Ending = "е", Skloneniye = Skloneniye.Second, Padezh = Padezh.Prepositional, NumberForm = NumberForm.Singular },
            new WordModelForDeclension { Ending = "ы", Skloneniye = Skloneniye.Second, Padezh = Padezh.Nominative, NumberForm = NumberForm.Plural },
            new WordModelForDeclension { Ending = "ов", Skloneniye = Skloneniye.Second, Padezh = Padezh.Genitive, NumberForm = NumberForm.Plural },
            new WordModelForDeclension { Ending = "ам", Skloneniye = Skloneniye.Second, Padezh = Padezh.Dative, NumberForm = NumberForm.Plural },
            new WordModelForDeclension { Ending = "ов", Skloneniye = Skloneniye.Second, Padezh = Padezh.Accusative, NumberForm = NumberForm.Plural },
            new WordModelForDeclension { Ending = "ами", Skloneniye = Skloneniye.Second, Padezh = Padezh.Instrumental, NumberForm = NumberForm.Plural },
            new WordModelForDeclension { Ending = "ах", Skloneniye = Skloneniye.Second, Padezh = Padezh.Prepositional, NumberForm = NumberForm.Plural },

            // Третье склонение
            new WordModelForDeclension { Ending = "", Skloneniye = Skloneniye.Third, Padezh = Padezh.Nominative, NumberForm = NumberForm.Singular },
            new WordModelForDeclension { Ending = "и", Skloneniye = Skloneniye.Third, Padezh = Padezh.Genitive, NumberForm = NumberForm.Singular },
            new WordModelForDeclension { Ending = "и", Skloneniye = Skloneniye.Third, Padezh = Padezh.Dative, NumberForm = NumberForm.Singular },
            new WordModelForDeclension { Ending = "ь", Skloneniye = Skloneniye.Third, Padezh = Padezh.Accusative, NumberForm = NumberForm.Singular },
            new WordModelForDeclension { Ending = "ью", Skloneniye = Skloneniye.Third, Padezh = Padezh.Instrumental, NumberForm = NumberForm.Singular },
            new WordModelForDeclension { Ending = "и", Skloneniye = Skloneniye.Third, Padezh = Padezh.Prepositional, NumberForm = NumberForm.Singular },
            new WordModelForDeclension { Ending = "и", Skloneniye = Skloneniye.Third, Padezh = Padezh.Nominative, NumberForm = NumberForm.Plural },
            new WordModelForDeclension { Ending = "ей", Skloneniye = Skloneniye.Third, Padezh = Padezh.Genitive, NumberForm = NumberForm.Plural },
            new WordModelForDeclension { Ending = "ям", Skloneniye = Skloneniye.Third, Padezh = Padezh.Dative, NumberForm = NumberForm.Plural },
            new WordModelForDeclension { Ending = "ей", Skloneniye = Skloneniye.Third, Padezh = Padezh.Accusative, NumberForm = NumberForm.Plural },
            new WordModelForDeclension { Ending = "ями", Skloneniye = Skloneniye.Third, Padezh = Padezh.Instrumental, NumberForm = NumberForm.Plural },
            new WordModelForDeclension { Ending = "ях", Skloneniye = Skloneniye.Third, Padezh = Padezh.Prepositional, NumberForm = NumberForm.Plural },
        };
    }
}

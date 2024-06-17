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

        //// Список окончаний
        //internal static readonly List<WordModelForDeclension> EndingModels = new List<WordModelForDeclension>()
        //{
        //    // Первое склонение
        //    ///new WordModelForDeclension { Ending = "", Skloneniye = Skloneniye.First, Padezh = Padezh.Nominative, NumberForm = NumberForm.Singular },
        //    new WordModelForDeclension { Ending = "а", Skloneniye = Skloneniye.First, Padezh = Padezh.Genitive, NumberForm = NumberForm.Singular },
        //    new WordModelForDeclension { Ending = "е", Skloneniye = Skloneniye.First, Padezh = Padezh.Dative, NumberForm = NumberForm.Singular },
        //    new WordModelForDeclension { Ending = "у", Skloneniye = Skloneniye.First, Padezh = Padezh.Accusative, NumberForm = NumberForm.Singular },
        //    new WordModelForDeclension { Ending = "ой", Skloneniye = Skloneniye.First, Padezh = Padezh.Instrumental, NumberForm = NumberForm.Singular },
        //    new WordModelForDeclension { Ending = "е", Skloneniye = Skloneniye.First, Padezh = Padezh.Prepositional, NumberForm = NumberForm.Singular },
        //    new WordModelForDeclension { Ending = "ы", Skloneniye = Skloneniye.First, Padezh = Padezh.Nominative, NumberForm = NumberForm.Plural },
        //    new WordModelForDeclension { Ending = "ов", Skloneniye = Skloneniye.First, Padezh = Padezh.Genitive, NumberForm = NumberForm.Plural },
        //    new WordModelForDeclension { Ending = "ам", Skloneniye = Skloneniye.First, Padezh = Padezh.Dative, NumberForm = NumberForm.Plural },
        //    new WordModelForDeclension { Ending = "ов", Skloneniye = Skloneniye.First, Padezh = Padezh.Accusative, NumberForm = NumberForm.Plural },
        //    new WordModelForDeclension { Ending = "ами", Skloneniye = Skloneniye.First, Padezh = Padezh.Instrumental, NumberForm = NumberForm.Plural },
        //    new WordModelForDeclension { Ending = "ах", Skloneniye = Skloneniye.First, Padezh = Padezh.Prepositional, NumberForm = NumberForm.Plural },

        //    // Второе склонение
        //    //new WordModelForDeclension { Ending = "", Skloneniye = Skloneniye.Second, Padezh = Padezh.Nominative, NumberForm = NumberForm.Singular },
        //    new WordModelForDeclension { Ending = "а", Skloneniye = Skloneniye.Second, Padezh = Padezh.Genitive, NumberForm = NumberForm.Singular },
        //    new WordModelForDeclension { Ending = "у", Skloneniye = Skloneniye.Second, Padezh = Padezh.Dative, NumberForm = NumberForm.Singular },
        //    new WordModelForDeclension { Ending = "а", Skloneniye = Skloneniye.Second, Padezh = Padezh.Accusative, NumberForm = NumberForm.Singular },
        //    new WordModelForDeclension { Ending = "ом", Skloneniye = Skloneniye.Second, Padezh = Padezh.Instrumental, NumberForm = NumberForm.Singular },
        //    new WordModelForDeclension { Ending = "е", Skloneniye = Skloneniye.Second, Padezh = Padezh.Prepositional, NumberForm = NumberForm.Singular },
        //    new WordModelForDeclension { Ending = "ы", Skloneniye = Skloneniye.Second, Padezh = Padezh.Nominative, NumberForm = NumberForm.Plural },
        //    new WordModelForDeclension { Ending = "ов", Skloneniye = Skloneniye.Second, Padezh = Padezh.Genitive, NumberForm = NumberForm.Plural },
        //    new WordModelForDeclension { Ending = "ам", Skloneniye = Skloneniye.Second, Padezh = Padezh.Dative, NumberForm = NumberForm.Plural },
        //    new WordModelForDeclension { Ending = "ов", Skloneniye = Skloneniye.Second, Padezh = Padezh.Accusative, NumberForm = NumberForm.Plural },
        //    new WordModelForDeclension { Ending = "ами", Skloneniye = Skloneniye.Second, Padezh = Padezh.Instrumental, NumberForm = NumberForm.Plural },
        //    new WordModelForDeclension { Ending = "ах", Skloneniye = Skloneniye.Second, Padezh = Padezh.Prepositional, NumberForm = NumberForm.Plural },

        //    // Третье склонение
        //    //new WordModelForDeclension { Ending = "", Skloneniye = Skloneniye.Third, Padezh = Padezh.Nominative, NumberForm = NumberForm.Singular },
        //    new WordModelForDeclension { Ending = "и", Skloneniye = Skloneniye.Third, Padezh = Padezh.Genitive, NumberForm = NumberForm.Singular },
        //    new WordModelForDeclension { Ending = "и", Skloneniye = Skloneniye.Third, Padezh = Padezh.Dative, NumberForm = NumberForm.Singular },
        //    new WordModelForDeclension { Ending = "ь", Skloneniye = Skloneniye.Third, Padezh = Padezh.Accusative, NumberForm = NumberForm.Singular },
        //    new WordModelForDeclension { Ending = "ью", Skloneniye = Skloneniye.Third, Padezh = Padezh.Instrumental, NumberForm = NumberForm.Singular },
        //    new WordModelForDeclension { Ending = "и", Skloneniye = Skloneniye.Third, Padezh = Padezh.Prepositional, NumberForm = NumberForm.Singular },
        //    new WordModelForDeclension { Ending = "и", Skloneniye = Skloneniye.Third, Padezh = Padezh.Nominative, NumberForm = NumberForm.Plural },
        //    new WordModelForDeclension { Ending = "ей", Skloneniye = Skloneniye.Third, Padezh = Padezh.Genitive, NumberForm = NumberForm.Plural },
        //    new WordModelForDeclension { Ending = "ям", Skloneniye = Skloneniye.Third, Padezh = Padezh.Dative, NumberForm = NumberForm.Plural },
        //    new WordModelForDeclension { Ending = "ей", Skloneniye = Skloneniye.Third, Padezh = Padezh.Accusative, NumberForm = NumberForm.Plural },
        //    new WordModelForDeclension { Ending = "ями", Skloneniye = Skloneniye.Third, Padezh = Padezh.Instrumental, NumberForm = NumberForm.Plural },
        //    new WordModelForDeclension { Ending = "ях", Skloneniye = Skloneniye.Third, Padezh = Padezh.Prepositional, NumberForm = NumberForm.Plural },
        //};
    }
}

using NumberToText.Shared.Enum;

namespace NumberToText.Shared.Models
{
    public class WordModelForDeclension
    {
        public string Ending {  get; set; }
        public NumberForm NumberForm { get; set; }
        public Skloneniye Skloneniye { get; set; }
        public Padezh Padezh { get; set; }
    }
}

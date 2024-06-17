namespace NumberToText.Shared.Enum
{
    /// <summary>
    /// Падежи
    /// </summary>
    public enum Padezh : sbyte
    {
        /// <summary>
        /// Именительный (кто? что?)
        /// </summary>
        Nominative = 0,
        /// <summary>
        /// Родительный (кого? чего?)
        /// </summary>
        Genitive = 1,
        /// <summary>
        /// Дательный (кому? чему?)
        /// </summary>
        Dative = 2,
        /// <summary>
        /// Винительный (кого? что?)
        /// </summary>
        Accusative = 3,
        /// <summary>
        /// Творительный (кем? чем?)
        /// </summary>
        Instrumental = 4,
        /// <summary>
        /// Предложный (о ком? о чем?)
        /// </summary>
        Prepositional = 5,
    }
}

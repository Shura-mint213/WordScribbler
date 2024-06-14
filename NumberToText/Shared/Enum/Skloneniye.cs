using System;
using System.Collections.Generic;
using System.Linq;
namespace NumberToText.Shared.Enum
{
    /// <summary>
    /// Склонения
    /// </summary>
    public enum Skloneniye : sbyte
    {
        /// <summary>
        /// Первое склонение (включает в себя существительные женского рода и мужского)
        /// </summary>
        First = 0,
        /// <summary>
        /// Второе склонение (включает в себя существительные среднего рода и мужского)
        /// </summary>
        Second = 1,
        /// <summary>
        /// Третье склонение (включает в себя существительные женского рода)
        /// </summary>
        Third = 2,
    }
}

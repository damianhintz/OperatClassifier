using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatsClassifier.Domain
{
    /// <summary>
    /// Reprezentuje słownik typów pliku.
    /// </summary>
    public class OperatFileType
    {
        /// <summary>
        /// Nazwa opisowa pozycji słownika.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Wartość pozycji słownika.
        /// </summary>
        public string Value { get; set; }
    }
}

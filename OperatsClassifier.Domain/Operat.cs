using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatsClassifier.Domain
{
    /// <summary>
    /// Reprezentuje operat.
    /// </summary>
    public class Operat
    {
        /// <summary>
        /// Położenie operatu.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Status operatu.
        /// </summary>
        public OperatState State { get; set; }
    }
}

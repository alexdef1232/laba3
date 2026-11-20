using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs3.Models
{
    public sealed class Concordance
    {
        public string Word { get; }
        public int Frequency { get; }
        public IReadOnlyList<int> LineNumbers { get; }

        public Concordance(string word, int frequency, IReadOnlyList<int> lineNumbers)
        {
            Word = word;
            Frequency = frequency;
            LineNumbers = lineNumbers;
        }

        public override string ToString()
            => $"{Word}. {Frequency}:{string.Concat(LineNumbers)}";
    }
}

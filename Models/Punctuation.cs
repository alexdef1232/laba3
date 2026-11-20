using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs3.Models
{
    public sealed class Punctuation : Tokens
    {
        public Punctuation(string value) : base(value) { }

        public bool IsEndOfSentence =>
            Value is "." or "!" or "?" or "…";

        public bool IsQuestionMark => Value == "?";
        public bool IsExclamationMark => Value == "!";
    }
}

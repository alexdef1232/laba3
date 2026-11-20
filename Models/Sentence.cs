namespace labs3.Models;
using System.Text;
using labs3.Models;

public sealed class Sentence
{
    private readonly List<Tokens> _tokens = new();

    public IReadOnlyList<Tokens> Tokens => _tokens;

    public IEnumerable<Words> Words => _tokens.OfType<Words>();

    public IEnumerable<Punctuation> Punctuations => _tokens.OfType<Punctuation>();

    public int WordCount => Words.Count();

    public int Length => _tokens.Sum(t => t.Value.Length);

    public bool IsQuestion =>
        Punctuations.Any(p => p.IsQuestionMark);

    public void Add(Tokens token)
    {
        ArgumentNullException.ThrowIfNull(token);
        _tokens.Add(token);
    }

    public void RemoveAllWords(Func<Words, bool> predicate)
    {
        _tokens.RemoveAll(t => t is Words w && predicate(w));
    }

    public void ReplaceWords(Func<Words, bool> predicate, string replacement)
    {
        for (int i = 0; i < _tokens.Count; i++)
        {
            if (_tokens[i] is Words w && predicate(w))
            {
                _tokens[i] = new Words(replacement);
            }
        }
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var token in _tokens)
        {
            if (token is Punctuation)
            {
                sb.Append(token.Value);
            }
            else
            {
                if (sb.Length > 0 && !char.IsWhiteSpace(sb[^1]))
                    sb.Append(' ');
                sb.Append(token.Value);
            }
        }
        return sb.ToString().Trim();
    }
}

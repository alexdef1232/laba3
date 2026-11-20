namespace labs3.Parsers;

using labs3.Models;

public interface ITextParser
{
    Text Parse(string content);
}
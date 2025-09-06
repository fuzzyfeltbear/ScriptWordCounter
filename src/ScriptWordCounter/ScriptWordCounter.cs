namespace ScriptWordCounter;

public static class Counter
{
    public static int Count(string input)
    {
        var count = 0;
        var insideBrackets = false;
        var insideSquareBrackets = false;

        var splits = input.Split([' ', '\r', '\n', '\t', '.', ','], StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        foreach (var word in splits)
        {
            if (word.StartsWith("(")) { insideBrackets = true; }
            if (word.StartsWith("[")) { insideSquareBrackets = true; }

            if (!insideBrackets && !insideSquareBrackets)
            {
                count++;
            }

            if (word.EndsWith(")")) { insideBrackets = false; }
            if (word.EndsWith("]")) { insideSquareBrackets = false; }
        }

        return count;
    }


}

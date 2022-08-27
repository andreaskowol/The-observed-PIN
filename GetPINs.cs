using System.Collections.Generic;
using System.Linq;

public class Kata
{
    private static List<string> answers;

    private static void FindAnswers(string str, List<char[]> options, int pos)
    {
        char[] head = options[pos];
        if (pos == options.Count - 1) answers.AddRange(head.Select(o => str + o));
        else foreach (char c in head) FindAnswers(str + c, options, pos + 1);
    }

    public static List<string> GetPINs(string observed)
    {
        answers = new List<string>();
        char[][] neighbours = "80,124,1235,236,1457,24568,3569,478,57890,689".Split(',').Select(s => s.ToArray()).ToArray();
        var options = observed.ToArray().Select(C => neighbours[C - '0']).ToList();
        FindAnswers("", options, 0);
        return answers;
    }
}

using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static List<string> GetPINs(string observed)
  {
    var result = new List<string> { "" };
    
    foreach (var c in observed)
    {
      result =
        (from r in result
         from a in AdjacentKeys[c]
         select $"{r}{a}").ToList();
    }
    
    return result;
  }
  
  public static Dictionary<char, IEnumerable<string>> AdjacentKeys =
    new Dictionary<char, IEnumerable<string>>()
  {
    { '1', new[] { "1", "2", "4" } },
    { '2', new[] { "1", "2", "3", "5" } },
    { '3', new[] { "2", "3", "6" } },
    { '4', new[] { "1", "4", "5", "7" } },
    { '5', new[] { "2", "4", "5", "6", "8" } },
    { '6', new[] { "3", "5", "6", "9" } },
    { '7', new[] { "4", "7", "8" } },
    { '8', new[] { "5", "7", "8", "9", "0" } },
    { '9', new[] { "6", "8", "9" } },
    { '0', new[] { "8", "0" } }
  };
}

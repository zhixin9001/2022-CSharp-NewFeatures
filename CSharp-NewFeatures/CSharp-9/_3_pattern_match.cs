namespace CSharp_9
{
  using System;

  public class _3_pattern_match
  {
    public static void Entry()
    {
      Console.WriteLine(IsLetter('d'));
      Console.WriteLine(IsLetterOrSeparator('d'));
      var a = "";
      if (a is not null)
      {
        Console.WriteLine(a);
      }
    }
    
    public static bool IsLetter( char c) =>
      c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
    
    public static bool IsLetterOrSeparator(char c) =>
      c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';
  }
}
namespace CSharp_8
{
  using System;

  public class _5_IndexAndRange
  {
    public static void Entry()
    {
      var words = new string[]
      {
        // index from start    index from end
        "The",      // 0                   ^9
        "quick",    // 1                   ^8
        "brown",    // 2                   ^7
        "fox",      // 3                   ^6
        "jumped",   // 4                   ^5
        "over",     // 5                   ^4
        "the",      // 6                   ^3
        "lazy",     // 7                   ^2
        "dog"       // 8                   ^1
      };              // 9 (or words.Length) ^0
      
      Console.WriteLine($"The last word is: {words[^2]}");
      
      var quickBrownFox = words[1..4];
      var lazyDog = words[^2..^0];

      Range r1 = 1..5;
      quickBrownFox = words[r1];

    }
    
  }
}
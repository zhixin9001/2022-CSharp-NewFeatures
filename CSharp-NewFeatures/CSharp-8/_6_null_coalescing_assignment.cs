namespace CSharp_8
{
  using System;
  using System.Collections.Generic;

  public class _6_null_coalescing_assignment
  {
    public static void Entry()
    {
      List<int> numbers = null;
      int? i = null;

      numbers ??= new List<int>();
      numbers.Add(i ??= 17);
      numbers.Add(i ??= 20);

      Console.WriteLine(string.Join(" ", numbers));  // output: 17 17
      Console.WriteLine(i);  // output: 17
    }
  }
}
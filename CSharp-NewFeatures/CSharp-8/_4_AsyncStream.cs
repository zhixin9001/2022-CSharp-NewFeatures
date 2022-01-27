namespace CSharp_8
{
  using System;
  using System.Threading.Tasks;

  public class _4_AsyncStream
  {
    public static async Task Entry()
    {
      await foreach (var number in GenerateSequence())
      {
        Console.WriteLine(number);
      }
    }
    
    public static async System.Collections.Generic.IAsyncEnumerable<int> GenerateSequence()
    {
      for (int i = 0; i < 20; i++)
      {
        await Task.Delay(100);
        yield return i;
      }
    }
  }
}
namespace CSharp_9
{
  using System;
  using System.Threading.Tasks;

  public class _2_init
  {
    public static async Task<string> Entry()
    {
      var mc = new MyClass()
      {
        B = "b"
      };
      Task.Delay(100);
      Console.WriteLine("123");
      
      MyClass mc1 = new();
      
      return "12333";
      // mc.B = "";

    }
  }

  class MyClass
  {
    public string A { get; } = "a";
    public string? B { get; init; }
  }
}
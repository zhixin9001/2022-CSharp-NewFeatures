namespace CSharp_8
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public class _3_switch
  {
    public static void Entry()
    {
      Props();
      // Console.WriteLine(Tuple_RockPaperScissors("paper", "rock"));
      // Console.WriteLine(GetQuadrant(new Point(1, 2)));
    }

    public static void Props()
    {
      var addresses = new List<Address>()
      {
        new Address() { State = "1" },
        new Address() { State = "2" },
        new Address() { State = "3" },
      };
      // todo: multi match
      var b = addresses.Select(add => add switch
      {
        var x when x.State=="1" || x.State=="2" => "22",
        { State: "1" } => "11",
        { State: "2" } => "22",
        { State: "3" } => "33",
        _ => throw new Exception()
      });
      Point point = new Point(1,2);
// Initialization:
      (int x, int y) = point;

// assignment:
      int x1 = 0;
      int y1 = 0;
      (x1, y1) = point;
      
      foreach (var b1 in b)
      {
        Console.WriteLine(b1);
      }
    }

    public static string Tuple_RockPaperScissors(string first, string second)
      => (first, second) switch
      {
        ("rock", "paper") => "rock is covered by paper. Paper wins.",
        ("rock", "scissors") => "rock breaks scissors. Rock wins.",
        ("paper", "rock") => "paper covers rock. Paper wins.",
        ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
        ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
        ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
        (_, _) => "tie"
      };

    public class Point
    {
      public int X { get; }
      public int Y { get; }

      public Point(int x, int y) => (X, Y) = (x, y);

      public void Deconstruct(out int x, out int y) =>
        (x, y) = (X, Y);
    }
    
    public enum Quadrant
    {
      Unknown,
      Origin,
      One,
      Two,
      Three,
      Four,
      OnBorder
    }
    
    static Quadrant GetQuadrant(Point point) => point switch
    {
      (0, 0) => Quadrant.Origin,
      var (x, y) when x > 0 && y > 0 => Quadrant.One,
      var (x, y) when x < 0 && y > 0 => Quadrant.Two,
      var (x, y) when x < 0 && y < 0 => Quadrant.Three,
      var (x, y) when x > 0 && y < 0 => Quadrant.Four,
      var (_, _) => Quadrant.OnBorder,
      _ => Quadrant.Unknown
    };
  }

  public class Address
  {
    public string State { get; set; }
  }
}
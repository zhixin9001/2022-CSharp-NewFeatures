namespace CSharp_10;

public class Test
{
  public Test1 P1 { get; set; }
}

public class Test1
{
  public string P2 { get; set; }
}

public class Point
{
  public int X { get; set; }
  public int Y { get; set; }
  public void Deconstruct(out int x, out int y) =>
    (x, y) = (X, Y);
}
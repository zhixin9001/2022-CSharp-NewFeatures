namespace CSharp_8
{
  using System;

  public class _1_Readonly
  {
    
  }
  public struct Point
  {
    public double X { get; set; }
    public double Y { get; set; }
    public readonly double Distance => Math.Sqrt(X * X + Y * Y);

    public readonly override string ToString() =>
      $"({X}, {Y}) is {Distance} from the origin";
  }
}
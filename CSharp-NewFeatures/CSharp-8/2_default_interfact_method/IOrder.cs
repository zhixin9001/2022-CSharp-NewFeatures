namespace CSharp_8._2_default_interfact_method
{
  using System;

  public interface IOrder
  {
    DateTime Purchased { get; }
    decimal Cost { get; }
  }
  
  public class SampleOrder : IOrder
  {
    public SampleOrder(DateTime purchase, decimal cost) =>
      (Purchased, Cost) = (purchase, cost);

    public DateTime Purchased { get; }

    public decimal Cost { get; }
  }
}
using System.Collections.Generic;
using System;

namespace PastryCost
{
  public class Pastry
  {
    public int Price { get; set; }
    public int Pastries(int quantity)
    {
      Price = 2;
      int cost = 0;
      while(quantity > 0)
      {
        if(quantity % 3 ==0)
        {
          cost += Price *2;
          quantity -=3;
        }
        else
        {
          cost += Price;
          quantity--;
        }
      }
      return cost;
    }
  }
}
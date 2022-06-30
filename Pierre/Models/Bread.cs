using System.Collections.Generic;
using System;

namespace BreadCost
{
  public class Bread
  {
    public int Price { get; set; }
    public int Breads(int quantity)
    {
      Price = 5;
      int cost = 0;
      while(quantity > 0)
      {
        if(quantity % 3 ==0)
        {
          cost += Price *2;
          quantity -= 3;
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
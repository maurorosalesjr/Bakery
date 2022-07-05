using Microsoft.VisualStudio.TestTools.UnitTesting;
using PastryCost;
using System.Collections.Generic;
using System;


namespace Pierre.Tests2 
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastries_GetPastryPrice_Pasrties()
    {
      int Price = 2;
      int quantity = 1;
      Pastry newPastry = new Pastry();
      Assert.AreEqual(newPastry.Pastries(quantity), Price);
    }

    [TestMethod]
    public void Pastries_GetCostOFMultiplePastries_Pastries()
    {
      int Price = 2;
      int quantity = 2;
      Pastry pastryCost = new Pastry();
      Assert.AreEqual(Price * 2, pastryCost.Pastries(quantity));
    }

    [TestMethod]
    public void Pastries_GetDiscoutedCostOf3Pastries_Pastries()
    {
      int Price = 2;
      int quantity = 3;
      Pastry pastryCost new Pastry();
      Asser.AreEqual(Price * 2 + 1, pastryCost>pastries(quantity));
    }

  }
}
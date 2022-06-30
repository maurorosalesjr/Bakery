using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;
using System.Collections.Generic;
using System;


namespace Pierre.Tests 
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Breads_GetBreadPrice_Breads()
    {
      int Price = 5;
      int quantity = 1;
      Bread newBread = new Bread();
      Assert.AreEqual(newBread.Breads(quantity), Price);
    }

    [TestMethod]
    public void Breads_GetCostOfMultipleBreads_Breads()
    {
      int Price = 5;
      int quantity = 6;
      Bread breadCost = new Bread();
      Assert.AreEqual(Price * 4, breadCost.Breads(quantity));
    }
  }
}
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
      Assert.AreEqual(newPastry.Pastries(quantity), Price)
    }
  }
}
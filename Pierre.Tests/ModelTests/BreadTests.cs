using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;
using System.Collections.Generic;
using System;
//using Bread;

namespace Pierre.Tests 
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_GetBreadPrice_Bread()
    {
      int Price = 5;
      Bread newBread = new Bread();
      Assert.AreEqual(newBread.Price, Price);
    }
  }
};
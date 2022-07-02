using System;
using System.Collections.Generic;
using PastryCost;
using BreadCost;
using System.Linq;

class Program
{
  static void Main()
  {

    Console.WriteLine("Welcome To:");
    Console.WriteLine("||===|| **                           ");
    Console.WriteLine("||   ||                              ");
    Console.WriteLine("||===|| || |==| ||/= ||/= |==| ' |== ");
    Console.WriteLine("||      || |__| ||   ||   |__|   |__ ");
    Console.WriteLine("||      || |___ ||   ||   |___    __|");
    Console.WriteLine("Bakery!!!");
    Console.WriteLine("Can I get you any tasty treats today? ['Y' for Yes, 'N' for No]");
    string answer = Console.ReadLine();

    if (answer == "Y" || answer == "y")
    {
      ShowMenu();
      YourOrder();   
      Checkout(Order);
    } 
    else if (answer == "N" || answer == "n")
    {
      Console.WriteLine("Well, uh... i guess... Thank You for visting Pierre's Bakery");
      Console.WriteLine("Please come back soon!");
      Console.WriteLine("@~*)~~*GOODBYE!*~~(*~@");
    } 
    else
    {
      Console.WriteLine("Please answer in to format given to you by our machine overlords...");
      Main();
    }


  }
  static void ShowMenu()
  {
    Console.WriteLine("_^_^_^_^_^_^_^_Menu_^_^_^_^_^_^_^_");
    Console.WriteLine("< Bread                Pastries >");
    Console.WriteLine("< 1 for $5             1 for $2 >");
    Console.WriteLine("< 3 for $10            3 for $5 >");
    Console.WriteLine("_################################_");
  }

  static Dictionary<string, int> Order = new Dictionary<string, int>()
  {
    {"Bread", 0},
    {"Pastry", 0}
  };

  static void ShowOrder(Dictionary<string, int> Order)
  {
    Console.WriteLine("You have {0} bread and {1} pastry", Order["Bread"], Order["Pastry"]);
  }

  static void YourOrder()
  {
    Console.WriteLine("How many loaves of Bread would you like?");
    string BreadQuantity = Console.ReadLine();
    int breadQuantity = int.Parse(BreadQuantity);
      if(breadQuantity >= 0)
      {          
        Order["Bread"] = breadQuantity;        
      }
      else
      {
        Console.WriteLine("Please put a positive integer for the amount of bread you would like.");
      }
    Console.WriteLine("How many Pastries would you like?");
    string PastryQuantity = Console.ReadLine();
    int pastryQuantity = int.Parse(PastryQuantity);
      if(pastryQuantity >= 0)
      {
        Order["Pastry"] = pastryQuantity;
      }
      else
      {
        Console.WriteLine("Please put a positive integer for the amount of pastries you would like.");
      }      
    Console.WriteLine("Your Order:");
    ShowOrder(Order);
  }
  
  static void Checkout(Dictionary<string, int> Order)
  {
    int total = 0;
    Bread bread = new Bread();
    Pastry pastry = new Pastry();
    total = bread.Breads(Order["Bread"]) + pastry.Pastries(Order["Pastry"]);
    Console.WriteLine("Your Total for {0} bread and {1} pastry will be ${2}.", Order["Bread"], Order["Pastry"], total);
  }
}
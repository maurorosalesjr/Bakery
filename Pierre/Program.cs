using System;
using System.Collections.Generic;
using PastryCost;
using BreadCost;
using System.Linq;

class Program
{
  static void Main()
  {

    Console.WriteLine("Welcome To Pierre's Bakery!");
    Console.WriteLine("Can I get you any tasty treats today? ['Y' for Yes, 'N' for No");
    string answer = Console.ReadLine();

    if (answer == "Y" || answer == "y")
    {
      ShowMenu();
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
}
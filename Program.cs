using System;
using System.Drawing;
using System.Collections.Generic;
using Console = Colorful.Console;
using Bakery.Models;
using StyleSheet = Colorful.StyleSheet;
namespace Bakery
{
  public class Program
  {
    public static string _bakeryArt = @"
      ||||
      ____
      |  |
      |__| _____________
  |==|____/_____________\___
  |==/UUUU|.---.---.---.|UUU\
  |=/UUUUU||___|___|___||UUUU\
  |/UUUUUU||___|___|___||UUUUU\
  /UUUUUUU'============='UUUUUU\
 /UUUUUUUUUUUUUUUUUUUUUUUUUUUUUU\__
 |''''''''''''''''''''''''''''''|=
 |== === Pierre's Bakery == = ==|-
 |= _______________ =  _______ =|=
 |=|:::|:::|:::|:::| =|.-----.|=|-
 |=|^^^|^^^|^^^|^^^|1O|||_|_|||=|=
 |=|---+---+---+---| =|||_|_|||=|=
 |=|   |   |   |   |= ||     ||=|-
 |=|___|___|___|___| =|| == O||=|=
 |='''''o&,@%8o''''' '||     ||=|-
 |= =.o%&hjw8@&o.== ==||_____||=|-
 ''''|__________|'''''/_______\' ''
                      '''''''''

------------------------------------------------";

    public static string _logo = @"
 _______   __                                        __                _______             __                                     
|       \ |  \                                      |  \              |       \           |  \                                    
| OOOOOOO\ \OO  ______    ______    ______    ______| OO_______       | OOOOOOO\  ______  | OO   __   ______    ______   __    __ 
| OO__/ OO|  \ /      \  /      \  /      \  /      \\O/       \      | OO__/ OO |      \ | OO  /  \ /      \  /      \ |  \  |  \
| OO    OO| OO|  OOOOOO\|  OOOOOO\|  OOOOOO\|  OOOOOO\|  OOOOOOO      | OO    OO  \OOOOOO\| OO_/  OO|  OOOOOO\|  OOOOOO\| OO  | OO
| OOOOOOO | OO| OO    OO| OO   \OO| OO   \OO| OO    OO \OO    \       | OOOOOOO\ /      OO| OO   OO | OO    OO| OO   \OO| OO  | OO
| OO      | OO| OOOOOOOO| OO      | OO      | OOOOOOOO _\OOOOOO\      | OO__/ OO|  OOOOOOO| OOOOOO\ | OOOOOOOO| OO      | OO__/ OO
| OO      | OO \OO     \| OO      | OO       \OO     \|       OO      | OO    OO \OO    OO| OO  \OO\ \OO     \| OO       \OO    OO
 \OO       \OO  \OOOOOOO \OO       \OO        \OOOOOOO \OOOOOOO        \OOOOOOO   \OOOOOOO \OO   \OO  \OOOOOOO \OO       _\OOOOOOO
                                                                                                                        |  \__| OO
                                                                                                                         \OO    OO
                                                                                                                          \OOOOOO 
";

    public static void TypeFast(string str)
    {
      for (int i = 0; i < str.Length; i++)
      {
        Console.Write(str[i]);
        System.Threading.Thread.Sleep(5);
      }
      Console.WriteLine();
    }
    public static void TypeSlow(string str)
    {
      for (int i = 0; i < str.Length; i++)
      {
        Console.Write(str[i]);
        System.Threading.Thread.Sleep(50);
      }
      Console.WriteLine();
    }
    public static bool yesOrNo(string input)
    {
      if (input == "y")
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public static void DisplayOptions(List<Bread> breadOptions, List<Pastry> pastryOptions)
    {
      TypeSlow("Breads:  ");
      foreach (Bread bread in breadOptions)
      {
        TypeSlow($"Name: {bread.TypeBread}, Price: ${bread.Price}");
      }
      TypeSlow("Pastries:  ");
      foreach (Pastry pastry in pastryOptions)
      {
        TypeSlow($"Name: {pastry.TypePastry}, Price: ${pastry.Price}");
      }

    }
    public static void Main()
    {
      Bread baguette = new Bread("Baguette", 2);
      Bread sour = new Bread("Sour Dough", 3);
      Bread loaf = new Bread("Loaf", 3);
      Bread olive = new Bread("Olive Bread", 4);
      Pastry donut = new Pastry("donut", 2);
      Pastry bear = new Pastry("Bear Claw", 3);
      Pastry muffin = new Pastry("Muffin", 3);
      Pastry choco = new Pastry("Chocolate muffin", 4);
      List<Bread> availabeBread = new List<Bread> { baguette, sour, loaf, olive };
      List<Pastry> availabePastry = new List<Pastry> { donut, bear, muffin, choco };

      TypeFast(_bakeryArt);
      TypeSlow("You see Pierre's in the distance would you like to go in? y/n ");
      string res = Console.ReadLine().ToLower();
      if (yesOrNo(res))
      {
        Order myOrder = new Order();
        DisplayOptions(availabeBread, availabePastry);

      }
      else
      {
        TypeSlow("Good Bye! Have a great day and come back soon!");
      }
    }
  }
}
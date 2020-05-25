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
    public static void SummerizeOrder(List<Bread> selectedBread, List<Pastry> selectedPastry)
    {
      int breadTotal = Bread.BreadDiscount(selectedBread);
      int pastryTotal = Pastry.PastryDiscount(selectedPastry);
      TypeSlow("Here is what you ordered: ");
      DisplayOptions(selectedBread, selectedPastry);
      TypeSlow($"And you Total is {breadTotal + pastryTotal}");
      TypeSlow($"Thank you and have a great day!");
    }
    public static void Ordering(List<Bread> breadOptions, List<Pastry> pastryOptions, List<Bread> selectedBread, List<Pastry> selectedPastry)
    {
      //List<Bread> selected = selectedBread;
      TypeSlow("Enter the name of what you want: ");
      string selection = Console.ReadLine().ToLower();
      TypeSlow($"Enter how many {selection}s you would like? ");
      int amount = int.Parse(Console.ReadLine());
      if (amount > 0)
      {
        switch (selection)
        {
          case "baguette":
            for (int i = 0; i < amount; i++)
            {
              selectedBread.Add(breadOptions[0]);
            }
            break;
          case "bagel":
            for (int i = 0; i < amount; i++)
            {
              selectedBread.Add(breadOptions[1]);
            }
            break;
          case "loaf":
            for (int i = 0; i < amount; i++)
            {
              selectedBread.Add(breadOptions[2]);
            }
            break;
          case "bolillio":
            for (int i = 0; i < amount; i++)
            {
              selectedBread.Add(breadOptions[3]);
            }
            break;
          //[pastries]
          case "donut":
            for (int i = 0; i < amount; i++)
            {
              selectedPastry.Add(pastryOptions[0]);
            }
            break;
          case "cookie":
            for (int i = 0; i < amount; i++)
            {
              selectedPastry.Add(pastryOptions[1]);
            }
            break;
          case "muffin":
            for (int i = 0; i < amount; i++)
            {
              selectedPastry.Add(pastryOptions[2]);
            }
            break;
          case "chocoroll":
            for (int i = 0; i < amount; i++)
            {
              selectedPastry.Add(pastryOptions[3]);
            }
            break;
          default:
            TypeSlow("Sorry invalid Type");
            Ordering(breadOptions, pastryOptions, selectedBread, selectedPastry);
            break;
        }
        TypeSlow("Would You like to add something else? y/n");
        string res = Console.ReadLine().ToLower();
        if (yesOrNo(res))
        {
          Ordering(breadOptions, pastryOptions, selectedBread, selectedPastry);
        }
        else
        {
          SummerizeOrder(selectedBread, selectedPastry);
        }
      }
      else
      {
        TypeSlow("Sorry invalid amount");
        Ordering(breadOptions, pastryOptions, selectedBread, selectedPastry);
      }
    }
    public static void Main()
    {
      Bread baguette = new Bread("Baguette", 2);
      Bread bagel = new Bread("Bagel", 3);
      Bread loaf = new Bread("Loaf", 3);
      Bread bolillo = new Bread("Bolillo", 4);
      Pastry donut = new Pastry("Donut", 2);
      Pastry cookie = new Pastry("Cookie", 3);
      Pastry muffin = new Pastry("Muffin", 3);
      Pastry chocoroll = new Pastry("Chocoroll", 4);
      List<Bread> availabeBread = new List<Bread> { baguette, bagel, loaf, bolillo };
      List<Pastry> availabePastry = new List<Pastry> { donut, cookie, muffin, chocoroll };
      List<Bread> selectedBread = new List<Bread> { };
      List<Pastry> selectedPastry = new List<Pastry> { };
      TypeFast(_bakeryArt);
      TypeSlow("You see Pierre's in the distance would you like to go in? y/n ");
      string res = Console.ReadLine().ToLower();
      if (yesOrNo(res))
      {

        DisplayOptions(availabeBread, availabePastry);
        Ordering(availabeBread, availabePastry, selectedBread, selectedPastry);
      }
      else
      {
        TypeSlow("Good Bye! Have a great day and come back soon!");
      }
    }
  }
}
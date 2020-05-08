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
    public static void SummerizeOrder(Order order)
    {
      TypeSlow("Here is what you ordered: ");
      DisplayOptions(order.BreadOrder, order.PastryOrder);
      TypeSlow($"And you Total is {order.SumTotal(order)}");
      TypeSlow($"Thank you and have a great day!");
    }
    public static void Ordering(List<Bread> breadOptions, List<Pastry> pastryOptions, Order order)
    {
      TypeSlow("Enter the name of what you want: ");
      string selection = Console.ReadLine().ToLower();
      int amount = int.Parse(Console.ReadLine());
      if (amount > 0)
      {
        switch (selection)
        {
          case "baguette":
            Console.WriteLine(breadOptions[0] + " " + amount.ToString());
            order.AddBread(breadOptions[0], amount);
            break;
          case "bagel":
            order.AddBread(breadOptions[1], amount);
            break;
          case "loaf":
            order.AddBread(breadOptions[2], amount);
            break;
          case "bolillio":
            order.AddBread(breadOptions[3], amount);
            break;
          case "donut":
            order.AddPastry(pastryOptions[0], amount);
            break;
          case "cookie":
            order.AddPastry(pastryOptions[1], amount);
            break;
          case "muffin":
            order.AddPastry(pastryOptions[2], amount);
            break;
          case "chocoroll":
            order.AddPastry(pastryOptions[3], amount);
            break;
          default:
            TypeSlow("Sorry invalid Type");
            Ordering(breadOptions, pastryOptions, order);
            break;
        }
        TypeSlow("Would You like to add something else? y/n");
        string res = Console.ReadLine().ToLower();
        if (yesOrNo(res))
        {
          Ordering(breadOptions, pastryOptions, order);
        }
        else
        {
          SummerizeOrder(order);
        }
      }
      else
      {
        TypeSlow("Sorry invalid amount");
        Ordering(breadOptions, pastryOptions, order);
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

      TypeFast(_bakeryArt);
      TypeSlow("You see Pierre's in the distance would you like to go in? y/n ");
      string res = Console.ReadLine().ToLower();
      if (yesOrNo(res))
      {
        Order myOrder = new Order();
        DisplayOptions(availabeBread, availabePastry);
        Ordering(availabeBread, availabePastry, myOrder);
      }
      else
      {
        TypeSlow("Good Bye! Have a great day and come back soon!");
      }
    }
  }
}
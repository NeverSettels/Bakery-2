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
      ____     _____________
  |==|____/_____________\___
  |==/UUUU|.---.---.---.|UUU\
  |=/UUUUU||___|___|___||UUUU\
  |/UUUUUU||___|___|___||UUUUU\
  /UUUUUUU'============='UUUUUU\
 /UUUUUUUUUUUUUUUUUUUUUUUUUUUUUU\__
 |''''''''''''''''''''''''''''''|=
 |== ===  = =Pie==  == =  ==|-
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
    public static void Main()
    {
      Console.WriteLine("hello", ConsoleColor.Blue);
      StyleSheet styleSheet = new StyleSheet(Color.Magenta);
      styleSheet.AddStyle("([O])*", Color.Blue);
      for (int i = 0; i < _logo.Length; i++)
      {
        Console.WriteStyled(_logo[i], styleSheet);
        System.Threading.Thread.Sleep(5);
      }
      Console.WriteLine();
    }
  }
}
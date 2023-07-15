using System;
using static System.Console;
using dotnet_poo.Models;

namespace dotnet_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 749, 72, 42, "Knight");
            WhiteWizard jenica = new WhiteWizard("Jenica", 325, 474, 42, "White Wizard");
            Ninja wedge = new Ninja("Wedge", 574, 89, 42, "Ninja");
            BlackWizard topapa = new BlackWizard("Topapa", 385, 611, 42, "Black Wizard");

            WriteLine(arus.ToString());
            WriteLine(arus.Attack());
            WriteLine(jenica.ToString());
            WriteLine(jenica.Attack(10));
            WriteLine(wedge.ToString());
            WriteLine(wedge.Attack());
            WriteLine(topapa.ToString());
            WriteLine(topapa.Attack());
        }
    }
}

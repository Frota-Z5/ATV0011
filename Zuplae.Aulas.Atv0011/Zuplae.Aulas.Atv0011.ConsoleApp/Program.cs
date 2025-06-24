using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Zuplae.Aulas.Atv0011.Models;

namespace Zuplae.Aulas.Atv0011.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Filme filme = new Filme("A Vida é Bela", "Drama", 1997, "Roberto Benigni");
            Atores ator = new Atores("Roberto Benigni", 70, "Italiano", null);

            Filme filme2 = new Filme("O Poderoso Chefão", "Crime", 1972, "Francis Ford Coppola");
            Atores ator2 = new Atores("Marlon Brando", 80, "Americano", filme2);

            Filme filme3 = new Filme("Forrest Gump", "Drama/Romance", 1994, "Robert Zemeckis");
            Atores ator3 = new Atores("Tom Hanks", 67, "Americano", filme3);

            Console.WriteLine("--------------- ATV0011 ---------------------\n");
            Console.WriteLine($"{ator}\n");
            Console.WriteLine($"{ator2}\n");
            Console.WriteLine($"{ator3} ");




        }
    }
}

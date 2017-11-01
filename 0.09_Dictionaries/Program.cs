using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze Challenge
            Dictionary<string, string> bestPic = new Dictionary<string, string>();
            bestPic.Add("2000", "American Beauty");
            bestPic.Add("2001", "Gladiator");
            bestPic.Add("2002", "A Beautiful Mind");
            bestPic.Add("2003", "Chicago");
            bestPic.Add("2004", "LOTR: Return of the King");
            bestPic.Add("2005", "Million Dollar Baby");
            
            foreach (var movie in bestPic)
            {
                Console.WriteLine($"In {movie.Key}, the winner was {movie.Value}.");
            }

            //Silver Challenge
            Dictionary<string, string[]> awardNominees = new Dictionary<string, string[]>()
            {
                { "2000", new string[] { "American Beauty", "The Cider House Rules", "The Green Mile" } },
                { "2001", new string[] { "Gladiator", "Chocolat", "Crouching Tiger, Hidden Dragon" } },
                { "2002", new string[] { "A Beautiful Mind", "Gosford Park", "In the Bedroom" } },
                { "2003", new string[] { "Chicago", "Gangs of New York", "The Hours" } },
                { "2004", new string[] { "LOTR: The Return of the King", "Lost in Translation", "M&C: The Far Side of the World" } },
                { "2005", new string[] { "Million Dollar Baby", "The Aviator", "Finding Neverland" } },
            };

            foreach (var nomineesByYear in awardNominees)
            {
                Console.WriteLine($"Nominees for {nomineesByYear.Key}: {nomineesByYear.Value[0]}, {nomineesByYear.Value[1]}, and {nomineesByYear.Value[2]}" );
            }

            Console.ReadLine();
            
        }
    }
}

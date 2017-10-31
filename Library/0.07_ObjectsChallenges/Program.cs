using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_ObjectsChallenges
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //Obect Instantiation
            Netflix show1 = new Netflix();
            Netflix show2 = new Netflix();
            Netflix show3 = new Netflix();

            //Set Object Values
            show1.Name = "Black Mirror";
            show1.Genre = "Science Fiction";
            show1.Rating = 4.5;

            show2.Name = "Stranger Things";
            show2.Genre = "Mystery";
            show2.Rating = 5.0;

            show3.Name = "The OA";
            show3.Genre = "Drama";
            show3.Rating = 2.0;

            //Calling the Methods (invoking, executing functions/methods)
            //show1.GetSuggestion();
            //show2.GetSuggestion();
            //show3.GetSuggestion();

            //Creating a List of Objects
            List<Netflix> favoriteShows = new List<Netflix>();

            favoriteShows.Add(show1);
            favoriteShows.Add(show2);
            favoriteShows.Add(show3);

            foreach (Netflix show in favoriteShows)
            {
                Console.WriteLine($"Show Name: {show.Name} | Genre: {show.Genre} | Rating: {show.Rating}");
            }

            Console.ReadLine();
        }
    }
}

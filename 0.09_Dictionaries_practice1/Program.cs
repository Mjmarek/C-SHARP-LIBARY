using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_CollectionDictionaries_practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string[]> catNicknamesById = new Dictionary<string, string[]>()
            {
                {"Benvolio", new string[] {"Benny", "Boo", "Boo Bear", "Boo Burrito", "Benny Boo"}},
                {"Lena", new string[] {"Fluff", "Fluffy", "Fluffy Girl", "Lena Girl", "Fluffawuffa"}},
                {"Licorice", new string[] {"Snuggie", "Snugglet", "Pistol", "Snugz", "Snugalug"}},
            };

            foreach (var nicknameEntry in catNicknamesById)
            {
                var nicknameList = ""; 

                for (int i = 0; i < nicknameEntry.Value.Length; i++)
                {
                    if (i < nicknameEntry.Value.Length - 1)
                        nicknameList = nicknameList + nicknameEntry.Value[i] + ", ";

                    else nicknameList = nicknameList + nicknameEntry.Value[i];
                }

                Console.WriteLine($"{nicknameEntry.Key}'s nicknames are {nicknameList}.");
            }
            Console.ReadLine();
        }
    }
}

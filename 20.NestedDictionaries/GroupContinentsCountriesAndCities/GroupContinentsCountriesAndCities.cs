using System;
using System.Collections.Generic;

namespace GroupContinentsCountriesAndCities
{
    public class GroupContinentsCountriesAndCities
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var dictionary = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            for (int i = 0; i < n; i++)
            {
                var currnetLine = Console.ReadLine().Split(' ');
                var continent = currnetLine[0];
                var country = currnetLine[1];
                var town = currnetLine[2];

                if (!dictionary.ContainsKey(continent))
                {
                    dictionary[continent] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!dictionary[continent].ContainsKey(country))
                {
                    dictionary[continent][country] = new SortedSet<string>();
                }

                dictionary[continent][country].Add(town);
            }

            foreach (var continentAndCountries in dictionary)
            {
                var continent = continentAndCountries.Key;
                var countries = continentAndCountries.Value;

                Console.WriteLine($"{continent}:");

                foreach (var countriesAndTowns in countries)
                {
                    var country = countriesAndTowns.Key;
                    var town = countriesAndTowns.Value;

                    Console.WriteLine($"  {country} -> {string.Join(", ",town)}");
                }
            }
        }
    }
}

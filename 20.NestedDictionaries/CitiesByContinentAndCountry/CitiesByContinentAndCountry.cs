using System;
using System.Collections.Generic;

namespace CitiesByContinentAndCountry
{
    public class CitiesByContinentAndCountry
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var dictionary = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var currnetContinent = Console.ReadLine().Split(' ');

                var continent = currnetContinent[0];
                var country = currnetContinent[1];
                var town = currnetContinent[2];

                if (!dictionary.ContainsKey(continent))
                {
                    dictionary[continent] = new Dictionary<string, List<string>>();
                }

                if (!dictionary[continent].ContainsKey(country))
                {
                    dictionary[continent][country] = new List<string>();
                }

                dictionary[continent][country].Add(town);
            }

            foreach (var continetsAndCountries in dictionary)
            {
                var continents = continetsAndCountries.Key;
                var countries = continetsAndCountries.Value;

                Console.WriteLine($"{continents}:");

                foreach (var contriesAndCities in countries)
                {
                    var country = contriesAndCities.Key;
                    var city = contriesAndCities.Value;

                    Console.WriteLine($"{country} -> {string.Join(", ",city)}");
                }
            }
        }
    }
}

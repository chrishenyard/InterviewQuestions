﻿// Given a list of cities "new york, detroit, miami", capitalize the first letter of each word: New York, Detroit, Miami

using System.Globalization;

namespace Questions
{
    public class TitleCase
    {
        private readonly List<string?> _titles;

        public TitleCase(List<string?> titles)
        {
            if (titles is null)
            {
                throw new ArgumentNullException(nameof(titles));
            }

            _titles = titles;
        }

        public void DisplayData()
        {
            var titles = _titles.Select(c =>
            {
                return !string.IsNullOrEmpty(c) ? CultureInfo.CurrentCulture.TextInfo.ToTitleCase(c.ToLower()) : c;
            });

            Console.WriteLine(String.Join(" ", titles));
        }
    }
}

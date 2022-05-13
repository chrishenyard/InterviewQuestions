using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.Topics
{
    public class Investor
    {
        public string Name { get; set; }
        public List<Investment> Investments { get; set; }

        public Investor(string name, List<Investment> investments) => (Name, Investments) = (name, investments);
    }

    public class Investment
    {
        public string Category { get; set; }
        public List<Category> Categories { get; set; }

        public Investment(string category, List<Category> categories) => (Category, Categories) = (category, categories);

    }

    public class Category
    {
        public string Sector { get; set; }
        public Category(string sector) => Sector = sector;
    }

    public static class Portfolio
    {
        public static List<Investor> GetInvestors()
        {
            var investors = new List<Investor>
            {
                new Investor("James", 
                    new List<Investment> 
                    { 
                        new Investment("Tech", new List<Category> { new Category("Microsoft"), new Category("Google") }),
                        new Investment("Bonds", new List<Category> { new Category("Florida"), new Category("Texas") }),
                    }
                ),
                new Investor("Thomas", 
                    new List<Investment> 
                    { 
                        new Investment("Bonds", new List<Category> { new Category("California"), new Category("New York") }) 
                    }
                ),
                new Investor("Mary", 
                    new List<Investment> 
                    { 
                        new Investment("S & P 500", new List<Category> { new Category("Las Vegas Sands Corp"), new Category("Wynn Resorts Ltd") }) 
                    }
                )
            };

            return investors;
        }
    }
}

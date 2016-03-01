using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckRegisteredCultures
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = new Settings();
            var cultures = new XMLparser(settings.CountryXmlPath).Cultures;
            var checker = new Checker(cultures);
            var culturesNotRegistered = checker.CulturesNotRegistered();
            if (culturesNotRegistered.Count>0)
            {
                Console.WriteLine("{0} cultures not registered:",culturesNotRegistered.Count);
                foreach (var culture in checker.CulturesNotRegistered())
                {
                    Console.WriteLine(culture);
                }
            }
            else
            {
                Console.WriteLine("All cultures in country.xml are already registered!");
            }
            
        }
    }
}

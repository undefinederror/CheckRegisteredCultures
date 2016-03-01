using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CheckRegisteredCultures
{
    class Checker
    {
        List<string> culturesToCheck;
        List<CultureInfo> allCultures;
        public Checker(List<string> culturesToCheck)
        {
            this.culturesToCheck = culturesToCheck;
            this.allCultures = CultureInfo.GetCultures(System.Globalization.CultureTypes.AllCultures).ToList();

        }
        public List<string> CulturesNotRegistered()
        {
            var culturesNotRegistered = new List<string>();

            return culturesToCheck.Where(x => allCultures.Find(y => y.Name == x)==null).ToList();
        }
    }
}

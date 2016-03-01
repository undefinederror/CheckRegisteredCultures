using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckRegisteredCultures
{
    class Settings
    {
        public string CountryXmlPath;
        public string ResisterCulturePath;
        public Settings()
        {
            CountryXmlPath = @"D:\dev\RayBan\RB2012-DEV\Web\RB.WebUI\_repository\_resources\_xml\countries.xml";
            ResisterCulturePath = @"D:\RegisterCulture.exe"; //not needed
        }
        
    }
}

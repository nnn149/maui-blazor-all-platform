using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazoribraryTest.Service;

namespace WpfAppTest.Service
{
    public class PlatformsService : IPlatformsService
    {
        public string GetCurrentPlatformName()
        {
            return "Wpf";
        }
    }
}

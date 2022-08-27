using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazoribraryTest.Service;

namespace MauiAppTest.Service
{
    public class PlatformsService : IPlatformsService
    {
        public string GetCurrentPlatformName()
        {
#if ANDROID
            return "Android";
#elif WINDOWS
            return "WinUI3";
#elif MACCATALYST
            return "MacCatalyst";
#elif IOS
            return "Ios";
#else
            return "None";
#endif
        }
    }
}

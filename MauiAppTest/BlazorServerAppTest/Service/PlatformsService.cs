using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazoribraryTest.Service;

namespace BlazorServerAppTest.Service
{
    public class PlatformsService : IPlatformsService
    {
        public string GetCurrentPlatformName()
        {
            return "Server";
        }
    }
}

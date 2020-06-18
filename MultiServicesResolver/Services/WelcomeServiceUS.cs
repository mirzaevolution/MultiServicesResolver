using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiServicesResolver.Services
{
    public class WelcomeServiceUS : IWelcomeService
    {
        public string GetMessage() => "Hello world from United States";
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Az.Func.V3.App.Services
{
    public class GreetingService : IGreetingService
    {
        public string Greet(string name)
        {
            return $"Hello {name}";
        }
    }
}

using System;
using System.Collections.Generic;
using Bug.Enums;
using Bug.Application;

namespace Bug
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var a = new App();
                a.Run();
            }
        } 
    }
}

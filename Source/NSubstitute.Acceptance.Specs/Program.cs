using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using NUnit.Common;
using NUnitLite;

namespace NSubstitute
{
    public class Program
    {
        public static int Main(string[] args)
        {
#if DNX451
            return new AutoRun().Execute(args);
#else
            var run = new AutoRun(typeof(Program).GetTypeInfo().Assembly).Execute(args, new ExtendedTextWrapper(Console.Out), Console.In);
            return run;

#endif
        }
    }
}

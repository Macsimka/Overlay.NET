using Overlay.NET.Common;
using System;

namespace Overlay.NET.Demo.Internals
{
    public class ConsoleLog : ILogger
    {
        public void WriteLine(string line) => Console.WriteLine(line);
    }
}

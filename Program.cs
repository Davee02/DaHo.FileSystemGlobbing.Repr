using System;
using System.Diagnostics;
using Microsoft.Extensions.FileSystemGlobbing;

namespace DaHo.FileSystemGlobbing.Repro
{
    class Program
    {
        static void Main(string[] args)
        {
            var matcher = new Matcher();

            matcher.AddInclude("file.txt");

            var matchResult = matcher.Match("file.txt");

            Trace.Assert(matchResult.HasMatches);

            Console.WriteLine("Assertion successful");
        }
    }
}

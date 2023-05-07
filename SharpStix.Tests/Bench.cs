using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using SharpStix.StixTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Running;
using Xunit.Abstractions;

namespace SharpStix.Tests
{
    public class Bench
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public Bench(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Benchmark()
        {
            _testOutputHelper.WriteLine(BenchmarkRunner.Run<Testerinos>().ToString());
        }
    }

    public class Testerinos
    {
        //[Benchmark]
        //public int Wrapper()
        //{
        //    Confidence c = new Confidence(Random.Shared.Next(1, 99));
        //    c += 1;
        //    int x = c;
        //    return x;
        //}

        //[Benchmark]
        //public int Base()
        //{
        //    int c = Random.Shared.Next(1, 99);
        //    c += 1;
        //    int x = c;
        //    return x;
        //}
    }
}

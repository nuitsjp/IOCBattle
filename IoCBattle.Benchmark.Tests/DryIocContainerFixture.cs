using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DryIoc;
using IocBattle.Benchmark.Tests;
using Xunit;

namespace IoCBattle.Benchmark.Tests
{
    public class DryIocContainerFixture : ContainerFixtureBase
    {
        [Fact]
        public void TestForSingleton()
        {
            var container = new DryIocContainer();
            container.SetupForSingletonTest();
            base.TestSingleton(container);
        }

        [Fact]
        public void TestForTransient()
        {
            var container = new DryIocContainer();
            container.SetupForTransientTest();
            base.TestTransient(container);
        }
    }
}

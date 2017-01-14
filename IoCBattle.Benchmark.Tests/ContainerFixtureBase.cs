using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IocBattle.Benchmark;
using IocBattle.Benchmark.Models;
using Xunit;

namespace IoCBattle.Benchmark.Tests
{
    public abstract class ContainerFixtureBase
    {
        protected void TestSingleton(IContainer container)
        {
            var first = container.Resolve<IWebService>();
            var second = container.Resolve<IWebService>();

            Assert.NotNull(first);
            Assert.NotNull(second);
            Assert.Equal(first, second);

            Assert.NotNull(first.Authenticator);
            Assert.NotNull(second.Authenticator);
            Assert.Equal(first.Authenticator, second.Authenticator);

            Assert.NotNull(first.Authenticator.Logger);
            Assert.NotNull(second.Authenticator.Logger);
            Assert.Equal(first.Authenticator.Logger, second.Authenticator.Logger);

            Assert.NotNull(first.Authenticator.ErrorHandler);
            Assert.NotNull(second.Authenticator.ErrorHandler);
            Assert.Equal(first.Authenticator.ErrorHandler, second.Authenticator.ErrorHandler);

            Assert.NotNull(first.Authenticator.ErrorHandler.Logger);
            Assert.NotNull(second.Authenticator.ErrorHandler.Logger);
            Assert.Equal(first.Authenticator.ErrorHandler.Logger, second.Authenticator.ErrorHandler.Logger);

            Assert.NotNull(first.Authenticator.Database);
            Assert.NotNull(second.Authenticator.Database);
            Assert.Equal(first.Authenticator.Database, second.Authenticator.Database);

            Assert.NotNull(first.Authenticator.Database.Logger);
            Assert.NotNull(second.Authenticator.Database.Logger);
            Assert.Equal(first.Authenticator.Database.Logger, second.Authenticator.Database.Logger);

            Assert.NotNull(first.Authenticator.Database.ErrorHandler);
            Assert.NotNull(second.Authenticator.Database.ErrorHandler);
            Assert.Equal(first.Authenticator.Database.ErrorHandler, second.Authenticator.Database.ErrorHandler);

            Assert.NotNull(first.Authenticator.Database.ErrorHandler.Logger);
            Assert.NotNull(second.Authenticator.Database.ErrorHandler.Logger);
            Assert.Equal(first.Authenticator.Database.ErrorHandler.Logger, second.Authenticator.Database.ErrorHandler.Logger);

            Assert.NotNull(first.StockQuote);
            Assert.NotNull(second.StockQuote);
            Assert.Equal(first.StockQuote, second.StockQuote);

            Assert.NotNull(first.StockQuote.Logger);
            Assert.NotNull(second.StockQuote.Logger);
            Assert.Equal(first.StockQuote.Logger, second.StockQuote.Logger);

            Assert.NotNull(first.StockQuote.ErrorHandler);
            Assert.NotNull(second.StockQuote.ErrorHandler);
            Assert.Equal(first.StockQuote.ErrorHandler, second.StockQuote.ErrorHandler);

            Assert.NotNull(first.StockQuote.ErrorHandler.Logger);
            Assert.NotNull(second.StockQuote.ErrorHandler.Logger);
            Assert.Equal(first.StockQuote.ErrorHandler.Logger, second.StockQuote.ErrorHandler.Logger);

            Assert.NotNull(first.StockQuote.Database);
            Assert.NotNull(second.StockQuote.Database);
            Assert.Equal(first.StockQuote.Database, second.StockQuote.Database);

            Assert.NotNull(first.StockQuote.Database.Logger);
            Assert.NotNull(second.StockQuote.Database.Logger);
            Assert.Equal(first.StockQuote.Database.Logger, second.StockQuote.Database.Logger);

            Assert.NotNull(first.StockQuote.Database.ErrorHandler);
            Assert.NotNull(second.StockQuote.Database.ErrorHandler);
            Assert.Equal(first.StockQuote.Database.ErrorHandler, second.StockQuote.Database.ErrorHandler);

            Assert.NotNull(first.StockQuote.Database.ErrorHandler.Logger);
            Assert.NotNull(second.StockQuote.Database.ErrorHandler.Logger);
            Assert.Equal(first.StockQuote.Database.ErrorHandler.Logger, second.StockQuote.Database.ErrorHandler.Logger);

        }

        protected void TestTransient(IContainer container)
        {
            var first = container.Resolve<IWebService>();
            var second = container.Resolve<IWebService>();

            Assert.NotNull(first);
            Assert.NotNull(second);
            Assert.NotEqual(first, second);

            Assert.NotNull(first.Authenticator);
            Assert.NotNull(second.Authenticator);
            Assert.NotEqual(first.Authenticator, second.Authenticator);

            Assert.NotNull(first.Authenticator.Logger);
            Assert.NotNull(second.Authenticator.Logger);
            Assert.NotEqual(first.Authenticator.Logger, second.Authenticator.Logger);

            Assert.NotNull(first.Authenticator.ErrorHandler);
            Assert.NotNull(second.Authenticator.ErrorHandler);
            Assert.NotEqual(first.Authenticator.ErrorHandler, second.Authenticator.ErrorHandler);

            Assert.NotNull(first.Authenticator.ErrorHandler.Logger);
            Assert.NotNull(second.Authenticator.ErrorHandler.Logger);
            Assert.NotEqual(first.Authenticator.ErrorHandler.Logger, second.Authenticator.ErrorHandler.Logger);

            Assert.NotNull(first.Authenticator.Database);
            Assert.NotNull(second.Authenticator.Database);
            Assert.NotEqual(first.Authenticator.Database, second.Authenticator.Database);

            Assert.NotNull(first.Authenticator.Database.Logger);
            Assert.NotNull(second.Authenticator.Database.Logger);
            Assert.NotEqual(first.Authenticator.Database.Logger, second.Authenticator.Database.Logger);

            Assert.NotNull(first.Authenticator.Database.ErrorHandler);
            Assert.NotNull(second.Authenticator.Database.ErrorHandler);
            Assert.NotEqual(first.Authenticator.Database.ErrorHandler, second.Authenticator.Database.ErrorHandler);

            Assert.NotNull(first.Authenticator.Database.ErrorHandler.Logger);
            Assert.NotNull(second.Authenticator.Database.ErrorHandler.Logger);
            Assert.NotEqual(first.Authenticator.Database.ErrorHandler.Logger, second.Authenticator.Database.ErrorHandler.Logger);

            Assert.NotNull(first.StockQuote);
            Assert.NotNull(second.StockQuote);
            Assert.NotEqual(first.StockQuote, second.StockQuote);

            Assert.NotNull(first.StockQuote.Logger);
            Assert.NotNull(second.StockQuote.Logger);
            Assert.NotEqual(first.StockQuote.Logger, second.StockQuote.Logger);

            Assert.NotNull(first.StockQuote.ErrorHandler);
            Assert.NotNull(second.StockQuote.ErrorHandler);
            Assert.NotEqual(first.StockQuote.ErrorHandler, second.StockQuote.ErrorHandler);

            Assert.NotNull(first.StockQuote.ErrorHandler.Logger);
            Assert.NotNull(second.StockQuote.ErrorHandler.Logger);
            Assert.NotEqual(first.StockQuote.ErrorHandler.Logger, second.StockQuote.ErrorHandler.Logger);

            Assert.NotNull(first.StockQuote.Database);
            Assert.NotNull(second.StockQuote.Database);
            Assert.NotEqual(first.StockQuote.Database, second.StockQuote.Database);

            Assert.NotNull(first.StockQuote.Database.Logger);
            Assert.NotNull(second.StockQuote.Database.Logger);
            Assert.NotEqual(first.StockQuote.Database.Logger, second.StockQuote.Database.Logger);

            Assert.NotNull(first.StockQuote.Database.ErrorHandler);
            Assert.NotNull(second.StockQuote.Database.ErrorHandler);
            Assert.NotEqual(first.StockQuote.Database.ErrorHandler, second.StockQuote.Database.ErrorHandler);

            Assert.NotNull(first.StockQuote.Database.ErrorHandler.Logger);
            Assert.NotNull(second.StockQuote.Database.ErrorHandler.Logger);
            Assert.NotEqual(first.StockQuote.Database.ErrorHandler.Logger, second.StockQuote.Database.ErrorHandler.Logger);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XunitPerTestLifeTimeTest.Tests
{
    public class CalcFixture : IAsyncLifetime
    {
        public Calculator Calc1 { get; private set; }
        public Calculator? Calc2 { get; private set; }

        public CalcFixture()
        {
            Calc1 = new Calculator();
        }

        public async Task InitializeAsync()
        {
            Calc2 = new Calculator();
            await Task.Delay(1);
        }

        public async Task DisposeAsync()
        {
            Calc2 = null;
            await Task.Delay(1);
        }
    }
}

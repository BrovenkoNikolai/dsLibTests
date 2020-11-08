using ds.test.impl.OperationPlugins;
using System;
using Xunit;

namespace ds.test.impl.Tests
{
    public class PluginsTests
    {
        [Fact]
        public void PluginSum_Test()
        {
            // arrange
            const int expSum = 3;
            var plgSum = new Plugins().GetPlugin(nameof(PluginSum));

            // act
            var actSum = plgSum.Run(1, 2);

            // assert
            Assert.Equal(expSum, actSum);
        }

        [Theory]
        [InlineData(3, 1)]
        [InlineData(3, 3)]
        public void PluginRandom_Error_Test(int expMin, int expMax)
        {
            // arrange
            var plgRnd = new Plugins().GetPlugin(nameof(PluginRandom));

            // act
            Action act = () => plgRnd.Run(expMin, expMax);

            // assert
            Assert.Throws<Exception>(act);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Rhino.Mocks.Tests
{
    internal static class Assert1
    {
        public static void Throws<T>(string msg, Action stuffThatGeneratesAnException)
        {
            try
            {
                stuffThatGeneratesAnException.Invoke();
                Assert.True(false, msg);
            }
            catch (Exception x) when (x is T)
            {
                Assert.Equal(msg, x.Message);
            }
        }
    }
}

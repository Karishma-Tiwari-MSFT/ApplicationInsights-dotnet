﻿#if NETCOREAPP2_0
namespace Microsoft.ApplicationInsights.Tests
{
    using Microsoft.ApplicationInsights.Extensibility.PerfCounterCollector.Implementation;
    using Microsoft.ApplicationInsights.Extensibility.PerfCounterCollector.Implementation.XPlatform;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// WebAppPerformanceCollector tests.
    /// </summary>
    [TestClass]
    public class PerformanceCollectorXPlatformTests : PerformanceCollectorXPlatformTestBase
    { 
        [TestMethod]        
        public void PerformanceCollectorSanityTest()
        {
           this.PerformanceCollectorSanityTest(new PerformanceCollectorXPlatform(), @"\Process(??APP_WIN32_PROC??)\% Processor Time Normalized", "Process", @"% Processor Time Normalized", null);
        }

        [TestMethod]        
        public void PerformanceCollectorAddRemoveCountersForXPlatformTest()
        {
            this.PerformanceCollectorAddRemoveCountersForXPlatformTest(new PerformanceCollectorXPlatform());
        }
    }
}
#endif
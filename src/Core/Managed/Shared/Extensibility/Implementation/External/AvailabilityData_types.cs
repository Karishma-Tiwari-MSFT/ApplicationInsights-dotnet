
//------------------------------------------------------------------------------
// This code was generated by a tool.
//
//   Tool : Bond Compiler 0.4.1.0
//   File : AvailabilityData_types.cs
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// <auto-generated />
//------------------------------------------------------------------------------


// suppress "Missing XML comment for publicly visible type or member"
#pragma warning disable 1591


#region ReSharper warnings
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable UnusedParameter.Local
// ReSharper disable RedundantUsingDirective
#endregion

namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External
{
    using System.Collections.Generic;

    
    [System.CodeDom.Compiler.GeneratedCode("gbc", "0.4.1.0")]
    internal partial class AvailabilityData
        : Domain
    {
        
        
        public int ver { get; set; }

        
        
        
        public string testRunId { get; set; }

        
        
        
        public string testTimeStamp { get; set; }

        
        
        
        public string testName { get; set; }

        
        
        
        public string duration { get; set; }

        
        public TestResult result { get; set; }

        
        
        
        public string runLocation { get; set; }

        
        
        
        public string message { get; set; }

        
        public double dataSize { get; set; }

        
        
        
        
        public IDictionary<string, string> properties { get; set; }

        
        
        
        public IDictionary<string, double> measurements { get; set; }

        public AvailabilityData()
            : this("AI.AvailabilityData", "AvailabilityData")
        {}

        protected AvailabilityData(string fullName, string name)
        {
            ver = 2;
            testRunId = "";
            testTimeStamp = "";
            testName = "";
            duration = "";
            runLocation = "";
            message = "";
            properties = new Dictionary<string, string>();
            measurements = new Dictionary<string, double>();
        }
    }
} // AI











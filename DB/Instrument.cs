//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Instrument
    {
        public int ID { get; set; }
        public string UnderlyingTicker { get; set; }
        public string UnderlyingName { get; set; }
        public string InstrumentTicker { get; set; }
        public double? Strike { get; set; }
        public double? Tenor { get; set; }
        public string CallOrPut { get; set; }
        public string InstType { get; set; }
        public double? Rebate { get; set; }
        public double? Barrier { get; set; }
    }
}
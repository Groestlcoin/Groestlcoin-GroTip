//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TipBot_BL.FantasyPortfolio
{
    using System;
    using System.Collections.Generic;
    
    public partial class FlipResults
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public string UserId { get; set; }
        public Nullable<byte> FlipResult { get; set; }
        public Nullable<byte> UserFlip { get; set; }
        public int IsWin { get; set; }
        public Nullable<decimal> FlipValue { get; set; }
    }
}

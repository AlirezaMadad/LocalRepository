//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KarYab.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OWNERSCONTRACT
    {
        public long ID { get; set; }
        public long CONTRACTOWNERID { get; set; }
        public long CONTRACTID { get; set; }
    
        public virtual CONTRACT CONTRACT { get; set; }
        public virtual HUMAN HUMAN { get; set; }
    }
}
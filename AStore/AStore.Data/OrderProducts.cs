//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AStore.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderProducts
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> StatusId { get; set; }
    
        public virtual Orders Orders { get; set; }
        public virtual Product Products { get; set; }
    }
}

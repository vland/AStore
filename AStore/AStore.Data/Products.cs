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
    
    public partial class Products
    {
        public Products()
        {
            this.OrderProducts = new HashSet<OrderProducts>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> CategoryId { get; set; }
    
        public virtual Categories Categories { get; set; }
        public virtual ProductStatuses ProductStatuses { get; set; }
        public virtual ICollection<OrderProducts> OrderProducts { get; set; }
    }
}

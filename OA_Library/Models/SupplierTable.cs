//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OA_Library.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SupplierTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SupplierTable()
        {
            this.PurchaseTables = new HashSet<PurchaseTable>();
        }
    
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public int UserID { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseTable> PurchaseTables { get; set; }
        public virtual UserTable UserTable { get; set; }
    }
}
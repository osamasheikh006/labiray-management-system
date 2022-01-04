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
    using System.ComponentModel.DataAnnotations;

    public partial class BookTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookTable()
        {
            this.BookFineTables = new HashSet<BookFineTable>();
            this.BookReturnTables = new HashSet<BookReturnTable>();
            this.IssueBookTables = new HashSet<IssueBookTable>();
            this.PurchaseDetailTables = new HashSet<PurchaseDetailTable>();
            this.PurTemDetailsTables = new HashSet<PurTemDetailsTable>();
        }

        public int BookID { get; set; }
        public int UserID { get; set; }
        [Required(ErrorMessage = "Please Select Department")]
        public int DepartmentID { get; set; }
        [Required(ErrorMessage = "Please Select Book Type")]
        public int BookTypeID { get; set; }
        [Required(ErrorMessage = "Please Enter Book Title")]
        public string BookTitle { get; set; }
        [Required(ErrorMessage = "Please Enter Short Description")]
        public string ShortDescription { get; set; }
        [Required(ErrorMessage = "Please Enter Author")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Please Enter Book Name")]
        public string BookName { get; set; }
        [Required(ErrorMessage = "Please Enter Edition")]
        public double Edition { get; set; }
        [Required(ErrorMessage = "Please Enter Total NO of Copies")]
        public int TotalCopies { get; set; }
        public System.DateTime RegDate { get; set; }
        [Required(ErrorMessage = "Please Enter Price")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookFineTable> BookFineTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookReturnTable> BookReturnTables { get; set; }
        public virtual BookTypeTable BookTypeTable { get; set; }
        public virtual DepartmentTable DepartmentTable { get; set; }
        public virtual UserTable UserTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssueBookTable> IssueBookTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseDetailTable> PurchaseDetailTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurTemDetailsTable> PurTemDetailsTables { get; set; }
    }
}

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

    public partial class EmployeeTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeTable()
        {
            this.BookFineTables = new HashSet<BookFineTable>();
            this.BookReturnTables = new HashSet<BookReturnTable>();
            this.IssueBookTables = new HashSet<IssueBookTable>();
            this.UserTables = new HashSet<UserTable>();
        }
    
        public int EmployeeID { get; set; }
        public int UserID { get; set; }
        [Required(ErrorMessage = "Please Enter Full Name")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Please Enter Father Name")]
        public string FatherName { get; set; }
        [Required(ErrorMessage = "Please Enter Contact NO")]
        public string ContactNo { get; set; }
        [Required(ErrorMessage = "Please Enter Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Select Designation")]
        public int DesignationID { get; set; }
        [Required(ErrorMessage = "Please Select Department")]
        public int DepartmentID { get; set; }
        [Display(Name ="Status")]
        public bool IsActive { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookFineTable> BookFineTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookReturnTable> BookReturnTables { get; set; }
        public virtual DepartmentTable DepartmentTable { get; set; }
        public virtual DesignationTable DesignationTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssueBookTable> IssueBookTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTable> UserTables { get; set; }
    }
}

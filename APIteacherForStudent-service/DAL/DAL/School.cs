//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class School
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public School()
        {
            this.ClassToSchools = new HashSet<ClassToSchool>();
        }
    
        public int id { get; set; }
        public string SchoolName { get; set; }
        public int IdCity { get; set; }
        public int idSchool { get; set; }
        public string comment { get; set; }
        public int IdSecretary { get; set; }
    
        public virtual City City { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassToSchool> ClassToSchools { get; set; }
        public virtual Secretary Secretary { get; set; }
    }
}
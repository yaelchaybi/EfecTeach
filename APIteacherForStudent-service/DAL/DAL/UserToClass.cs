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
    
    public partial class UserToClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserToClass()
        {
            this.Proffestions = new HashSet<Proffestion>();
        }
    
        public int id { get; set; }
        public int idUser { get; set; }
        public int idClass { get; set; }
        public int approved { get; set; }
        public System.DateTime LastDateOfStatusChange { get; set; }
        public string factor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proffestion> Proffestions { get; set; }
        public virtual User User { get; set; }
    }
}

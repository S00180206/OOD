//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IndividualProject_S00180206
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShowDiscription
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShowDiscription()
        {
            this.Shows = new HashSet<Show>();
        }
    
        public int Id { get; set; }
        public string Genre { get; set; }
        public int NumberOfSeasons { get; set; }
        public string Description { get; set; }
        public int ViewerCount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Show> Shows { get; set; }
    }
}

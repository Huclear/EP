//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practice4.database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Album
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Album()
        {
            this.AlbumsPodcasts = new HashSet<AlbumsPodcasts>();
        }
    
        public int ID_Album { get; set; }
        public string Album_Name { get; set; }
        public string Album_Description { get; set; }
        public int Author_ID { get; set; }
    
        public virtual Author Author { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlbumsPodcasts> AlbumsPodcasts { get; set; }
        public override string ToString()
        {
            return Album_Name;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practice1.database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Podcast
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Podcast()
        {
            this.AlbumsPodcasts = new HashSet<AlbumsPodcasts>();
            this.Episode = new HashSet<Episode>();
        }
    
        public int ID_Podcast { get; set; }
        public string Podcast_Name { get; set; }
        public string Podcast_Description { get; set; }
        public int Author_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlbumsPodcasts> AlbumsPodcasts { get; set; }
        public virtual Author Author { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Episode> Episode { get; set; }
    }
}

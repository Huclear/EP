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
    
    public partial class AlbumsPodcasts
    {
        public int ID_AlbumsPodcasts { get; set; }
        public int Album_ID { get; set; }
        public int Podcast_ID { get; set; }
    
        public virtual Album Album { get; set; }
        public virtual Podcast Podcast { get; set; }

        public override string ToString()
        {
            return $"Album: {Album_ID}/ Podcast: {Podcast_ID}";
        }
    }
}

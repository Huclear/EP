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
    
    public partial class Episode
    {
        public int ID_Episode { get; set; }
        public string Episode_Name { get; set; }
        public string Episode_Description { get; set; }
        public decimal Episode_Duration { get; set; }
        public int Podcast_ID { get; set; }
    
        public virtual Podcast Podcast { get; set; }
    }
}

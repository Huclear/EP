using Practice3.database;
using Practice3.database.PodcastsDBDataSetTableAdapters;
using Practice3.pages_EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Practice3.ViewModels
{
    public class DataSetDBViewModel
    {
        public PodcastsDBDataSet ctx { get; private set; }
        public AuthorTableAdapter Authors { get; private set; }
        public AlbumsPodcastsTableAdapter AlbumsPodcasts { get; private set; }
        public AlbumTableAdapter Albums { get; private set; }
        public PodcastTableAdapter Podcasts { get; private set; }
        public EpisodeTableAdapter Episodes { get; private set; }


        public DataSetDBViewModel()
        {
            ctx = new PodcastsDBDataSet();
            Authors = new AuthorTableAdapter();
            AlbumsPodcasts = new AlbumsPodcastsTableAdapter();
            Albums = new AlbumTableAdapter();
            Podcasts = new PodcastTableAdapter();
            Episodes = new EpisodeTableAdapter();
        }
    }
}

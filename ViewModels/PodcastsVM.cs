using Practice3.database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace Practice3
{
    public class PodcastsVM
    {

        public PodcastDBContext dbContext { get; private set; }

        public ObservableCollection<Podcast> Podcasts { get; set; }
        public ObservableCollection<Episode> Episodes { get; set; }
        public ObservableCollection<Author> Authors { get; set; }
        public ObservableCollection<Album> Albums { get; set; }
        public ObservableCollection<AlbumsPodcasts> Albums_Podcasts { get; set; }

        public PodcastsVM()
        {
            dbContext = new PodcastDBContext();
            Podcasts = new ObservableCollection<Podcast>( dbContext.Podcast.ToList());
            Episodes = new ObservableCollection<Episode>(dbContext.Episode.ToList());
            Authors = new ObservableCollection<Author>(dbContext.Author.ToList());
            Albums = new ObservableCollection<Album>(dbContext.Album.ToList());
            Albums_Podcasts = new ObservableCollection<AlbumsPodcasts>(dbContext.AlbumsPodcasts.ToList());
        }
    }
}

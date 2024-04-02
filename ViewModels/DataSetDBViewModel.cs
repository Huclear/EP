using Practice4.database;
using Practice4.database.PodcastsPlaylistsDataSetTableAdapters;
using Practice4.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Practice4.ViewModels
{
    public class DataSetDBViewModel
    {
        public PodcastDBDataSet ctx { get; private set; }
        public AuthorTableAdapter Authors { get; private set; }
        public AlbumsPodcastsTableAdapter AlbumsPodcasts { get; private set; }
        public AlbumTableAdapter Albums { get; private set; }
        public PodcastTableAdapter Podcasts { get; private set; }
        public EpisodeTableAdapter Episodes { get; private set; }


        public DataSetDBViewModel()
        {
            ctx = new PodcastDBDataSet();
            Authors = new AuthorTableAdapter();
            AlbumsPodcasts = new AlbumsPodcastsTableAdapter();
            Albums = new AlbumTableAdapter();
            Podcasts = new PodcastTableAdapter();
            Episodes = new EpisodeTableAdapter();
        }

        public ICollection<PodcastDBDataSet.AuthorRow> getAuthorsPatronymicsEntries()
        {
            List<PodcastDBDataSet.AuthorRow> authors = new List<PodcastDBDataSet.AuthorRow>();
            foreach (var author in Authors.GetData().ToList())
            {
                if(!author.IsAuthor_PatronymicNull())
                    authors.Add(author);
            }
            return authors;
        }

        public ICollection<PodcastDBDataSet.PodcastRow> GetPodcastsDescriptionEntries()
        {
            List<PodcastDBDataSet.PodcastRow> podcasts = new List<PodcastDBDataSet.PodcastRow>();
            foreach (var podcast in Podcasts.GetData().ToList())
            {
                if (!podcast.IsPodcast_DescriptionNull())
                    podcasts.Add(podcast);
            }
            return podcasts;
        }

        public ICollection<PodcastDBDataSet.AlbumRow> GetAlbumsDescriptionEntries()
        {
            List<PodcastDBDataSet.AlbumRow> albums = new List<PodcastDBDataSet.AlbumRow>();
            foreach (var album in Albums.GetData().ToList())
            {
                if (!album.IsAlbum_DescriptionNull())
                    albums.Add(album);
            }
            return albums;
        }
        public ICollection<PodcastDBDataSet.EpisodeRow> GetEpisodesDescriptionEntries()
        {
            List<PodcastDBDataSet.EpisodeRow> episodes = new List<PodcastDBDataSet.EpisodeRow>();
            foreach (var episode in Episodes.GetData().ToList())
            {
                if (!episode.IsEpisode_DescriptionNull())
                    episodes.Add(episode);
            }
            return episodes;
        }
    }
}

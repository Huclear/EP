using Practice2.database;
using Practice2.database.PodcastDBDataSetTableAdapters;
using Practice2.pages;
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

namespace Practice2.ViewModels
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

        public void AddAuthor(string author_Name, string author_surname, string author_Patronymic, string nickname, int age)
        {
            Authors.InsertQuery(author_Name, author_surname, author_Patronymic, nickname, age);
        }

        public void AddAlbumsPodcasts(int albumID, int podcastID)
        {
            AlbumsPodcasts.InsertQuery(albumID, podcastID);
        }

        public void AddAlbum(string name, string description, int authorID)
        {
            Albums.InsertQuery(name, description, authorID);
        }

        public void AddPodcast(string name, string description, int authorID)
        {
            Podcasts.InsertQuery(name, description, authorID);
        }

        public void AddEpisode(string name, string description, decimal duration, int podcastID)
        {
            Episodes.InsertQuery(name, description, duration, podcastID);
        }


        public void UpdateAuthor(string author_Name, string author_surname, string author_Patronymic, string nickname, int age, int originalID)
        {
            Authors.UpdateQuery(author_Name, author_surname, author_Patronymic, nickname, age, originalID);
        }

        public void UpdateAlbumsPodcasts(int albumID, int podcastID, int originalID)
        {
            AlbumsPodcasts.UpdateQuery(albumID, podcastID, originalID);
        }

        public void UpdateAlbum(string name, string description, int authorID, int originalID)
        {
            Albums.UpdateQuery(name, description, authorID, originalID);
        }

        public void UpdatePodcast(string name, string description, int authorID, int originalID)
        {
            Podcasts.UpdateQuery(name, description, authorID, originalID);
        }

        public void UpdateEpisode(string name, string description, decimal duration, int authorID, int originalID)
        {
            Episodes.UpdateQuery(name, description, duration, authorID, originalID);
        }

        public void DeleteFrom(Tables table, int originalID)
        {
            try
            {
                switch (table)
                {
                    case Tables.Author:
                        Authors.DeleteQuery(originalID);
                        break;
                    case Tables.Albums_Podcasts:
                        AlbumsPodcasts.DeleteQuery(originalID);
                        break;
                    case Tables.Album:
                        Albums.DeleteQuery(originalID);
                        break;
                    case Tables.Podcast:
                        Podcasts.DeleteQuery(originalID);
                        break;
                    case Tables.Episodes:
                        Episodes.DeleteQuery(originalID);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

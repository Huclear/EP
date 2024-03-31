using Practice2.Commands;
using Practice2.database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace Practice2
{
    public class PodcastsVM
    {
        private RelayCommand<Podcast> _deletePodcastCommand = null;
        public RelayCommand<Podcast> deletePodcastCommand => _deletePodcastCommand ?? (new RelayCommand<Podcast>(DeletePodcast));

        private RelayCommand<Author> _deleteAuthorCommand = null;
        public RelayCommand<Author> deleteAuthorCommand => _deleteAuthorCommand ?? (new RelayCommand<Author>(DeleteAuthor));

        private RelayCommand<Album> _deleteAlbumCommand = null;
        public RelayCommand<Album> deleteAlbumCommand => _deleteAlbumCommand ?? (new RelayCommand<Album>(DeleteAlbum));

        private RelayCommand<Episode> _deleteEpisodeCommand = null;
        public RelayCommand<Episode> deleteEpisodeCommand => _deleteEpisodeCommand ?? (new RelayCommand<Episode>(DeleteEpisode));

        private RelayCommand<AlbumsPodcasts> _deleteAlbums_PodcastsCommand = null;
        public RelayCommand<AlbumsPodcasts> deleteAlbums_PodcastsCommand => _deleteAlbums_PodcastsCommand ?? (new RelayCommand<AlbumsPodcasts>(DeleteAlbumsPodcasts));


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

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        private void DeletePodcast(Podcast podcast)
        {
            try
            {
                if (podcast != null && Podcasts.Contains(podcast))
                {
                    Podcasts.Remove(podcast);
                    dbContext.Podcast.Remove(podcast);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteAuthor(Author author)
        {
            try
            {
                if (author != null && Authors.Contains(author))
                {
                    Authors.Remove(author);
                    dbContext.Author.Remove(author);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteAlbum(Album album)
        {
            try
            {
                if (album != null && Albums.Contains(album))
                {
                    Albums.Remove(album);
                    dbContext.Album.Remove(album);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteAlbumsPodcasts(AlbumsPodcasts albumsPodcasts)
        {
            try
            {
                if (albumsPodcasts != null && Albums_Podcasts.Contains(albumsPodcasts))
                {
                    Albums_Podcasts.Remove(albumsPodcasts);
                    dbContext.AlbumsPodcasts.Remove(albumsPodcasts);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteEpisode(Episode episode)
        {
            try
            {
                if (episode != null && Episodes.Contains(episode))
                {
                    Episodes.Remove(episode);
                    dbContext.Episode.Remove(episode);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        public void AddPodcast()
        {
            try
            {
                Podcast newPodcast = new Podcast() { Author_ID = 1, Podcast_Name = "enter podcast name" };
                Podcasts.Add(newPodcast);
                dbContext.Podcast.Add(newPodcast);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void AddAuthor()
        {
            try
            {
                Author newAuthor = new Author() { Author_Name = "enter your name", Author_SurName = "enter your surname", Author_Nickname = "enter your nickname", Author_Age = 1 };
                Authors.Add(newAuthor);
                dbContext.Author.Add(newAuthor);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void AddAlbum()
        {
            try
            {
                Album newAlbum = new Album() { Author_ID = 1, Album_Name="enter album name" };
                Albums.Add(newAlbum);
                dbContext.Album.Add(newAlbum);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void AddEpisode()
        {
            try
            {
                Episode newEpisode = new Episode() { Podcast_ID = 1, Episode_Name = "enter episode name" };
                Episodes.Add(newEpisode);
                dbContext.Episode.Add(newEpisode);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        public void AddAlbumsPodcasts(int podcastID, int albumID)
        {
            try
            {
                AlbumsPodcasts newAlbumsPodcasts = new AlbumsPodcasts() { Podcast_ID = podcastID, Album_ID = albumID };
                Albums_Podcasts.Add(newAlbumsPodcasts);
                dbContext.AlbumsPodcasts.Add(newAlbumsPodcasts);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}

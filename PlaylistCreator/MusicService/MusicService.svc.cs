using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MusicService
{

    public class MusicService : IMusicService
    {
        public Song AddArtist(string songKey, string artistKey)
        {
            using(SqlConnection r = new SqlConnection())
            {
                using(SqlTransaction t = r.BeginTransaction())
                {
                    using(SqlCommand cmd = new SqlCommand("INSERT SQL STATEMENT HERE" ,r,t))
                    {

                    }
                }
            }
            throw new NotImplementedException();
        }

        public Stream API()
        {
            throw new NotImplementedException();
        }

        public Artist CreateArtist(Artist artist)
        {
            throw new NotImplementedException();
        }

        public Song CreateSong(Song song)
        {
            throw new NotImplementedException();
        }

        public void DeleteSong(Song song)
        {
            throw new NotImplementedException();
        }

        public Song GetSongInfo(string songKey, string brief)
        {
            throw new NotImplementedException();
        }
    }
}

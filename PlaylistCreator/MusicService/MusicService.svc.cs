using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MusicService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class MusicService : IMusicService
    {
        public Song AddArtist(string songKey, string artistKey)
        {
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

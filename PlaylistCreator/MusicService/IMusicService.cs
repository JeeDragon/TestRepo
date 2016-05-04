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

    [ServiceContract]
    public interface IMusicService
    {

        /// <summary>
        /// Sends back index.html as the response body.
        /// </summary>
        [WebGet(UriTemplate = "/api")]
        Stream API();

        /// <summary>
        /// Creates a new song from a Song object.
        /// </summary>
        /// <param name="song"></param>
        /// <returns>Song</returns>
        [WebInvoke(Method = "POST", UriTemplate = "/song")]
        Song CreateSong(Song song);

        /// <summary>
        /// Creates an Artist object only if the Artist hasn't already been created and resides in the db.
        /// </summary>
        /// <param name="requestBody"></param>
        /// <returns></returns>
        [WebInvoke(Method = "POST", UriTemplate = "/artist")]
        Artist CreateArtist(Artist artist);

        /// <summary>
        /// Deletes the specified song using the SongKey.
        /// </summary>
        /// <param name="song"></param>
        [WebInvoke(Method = "DELETE", UriTemplate = "/song")]
        void DeleteSong(Song song);

        /// <summary>
        /// Adds an artist to the specified song using the songKey to get the correct song.
        /// </summary>
        /// <param name="songKey"></param>
        /// <param name="song"></param>
        /// <returns></returns>
        [WebInvoke(Method = "PUT", UriTemplate = "/song/{songKey}/{artistKey}")]
        Song AddArtist(string songKey, string artistKey);

        /// <summary>
        /// Returns the song object with all the information. If brief = yes more information is provided, else a concise
        /// description is returned.
        /// </summary>
        /// <param name="songKey"></param>
        /// <param name="brief"></param>
        /// <returns></returns>
        [WebGet(UriTemplate = "/song/{songKey}?Brief={brief}")]
        Song GetSongInfo(string songKey, string brief);
    }

    [DataContract]
    public class Song
    {
        [DataMember]
        public string SongName { get; set; }
        [DataMember]
        public List<Artist> Artists { get; set; }
        [DataMember]
        public Guid SongKey { get; set; }
        public Song(string songName)
        {
            SongName = songName;
            SongKey = new Guid();
            Artists = new List<Artist>();
        }
    }

    [DataContract]
    public class Artist
    {
        [DataMember]
        public string ArtistName { get; set; }
        [DataMember]
        public Guid ArtistKey { get; set; }
        public Artist(string artistName)
        {
            ArtistName = artistName;
            ArtistKey = new Guid();
        }
    }
}

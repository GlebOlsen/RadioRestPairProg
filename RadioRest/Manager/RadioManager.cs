using RadioRest.Models;
using System.Collections.Generic;


namespace RadioRest.Manager
{
    public class RadioManager
    {
        private static int _nextId = 1;
        private static int _nextAlbumId = 1;

        private static List<Album> _albums = new List<Album>()
        {
            new Album {Id = _nextAlbumId++, Title = "Beliber", Songs = 1,
                MusicRecord = new List<MusicRecord>
                {
                    new MusicRecord{Id =_nextId++, Title= "Baby Oh", Artist = "Justin Biber",DurationInSec = 250,YearOfPublication = 2009, AlbumId = _nextAlbumId-1},
                    new MusicRecord{Id =_nextId++, Title= "Baby Oh", Artist = "Justin Biber",DurationInSec = 250,YearOfPublication = 2009, AlbumId = _nextAlbumId-1},
                    new MusicRecord{Id =_nextId++, Title= "Baby Oh", Artist = "Justin Biber",DurationInSec = 250,YearOfPublication = 2009, AlbumId = _nextAlbumId-1},
                    new MusicRecord{Id =_nextId++, Title= "Baby Oh", Artist = "Justin Biber",DurationInSec = 250,YearOfPublication = 2009, AlbumId = _nextAlbumId-1},
                    new MusicRecord{Id =_nextId++, Title= "Baby Oh", Artist = "Justin Biber",DurationInSec = 250,YearOfPublication = 2009, AlbumId = _nextAlbumId-1},
                    new MusicRecord{Id =_nextId++, Title= "Baby Oh", Artist = "Justin Biber",DurationInSec = 250,YearOfPublication = 2009, AlbumId = _nextAlbumId-1},
                    new MusicRecord{Id =_nextId++, Title= "Baby Oh", Artist = "Justin Biber",DurationInSec = 250,YearOfPublication = 2009, AlbumId = _nextAlbumId-1},
                    new MusicRecord{Id =_nextId++, Title= "Baby Oh", Artist = "Justin Biber",DurationInSec = 250,YearOfPublication = 2009, AlbumId = _nextAlbumId-1},
                    new MusicRecord{Id =_nextId++, Title= "Baby Oh", Artist = "Justin Biber",DurationInSec = 250,YearOfPublication = 2009, AlbumId = _nextAlbumId-1},
                    new MusicRecord{Id =_nextId++, Title= "Baby Oh", Artist = "Justin Biber",DurationInSec = 250,YearOfPublication = 2009, AlbumId = _nextAlbumId-1},
                    new MusicRecord{Id =_nextId++, Title= "Baby Oh", Artist = "Justin Biber",DurationInSec = 250,YearOfPublication = 2009, AlbumId = _nextAlbumId-1},
                    new MusicRecord{Id =_nextId++, Title= "Baby Oh", Artist = "Justin Biber",DurationInSec = 250,YearOfPublication = 2009, AlbumId = _nextAlbumId-1}
                }
            },
            
            //new MusicRecord(_nextId++,"I gotta feeling","Black Eye Peace",230,2009)
        };

        public List<Album> GetAll()
        {
            List<Album> albums = new List<Album>(_albums);
            albums.Sort((Album, Album1) => Album1.Id - Album.Id);
            return albums;
        }

        public List<MusicRecord> GetMusicRecord(int albumId)
        {
            Album album = _albums.Find(a => a.Id == albumId);
            if (album == null) return null;
            List<MusicRecord> musicRecords = album.MusicRecord;
            musicRecords.Sort((musicRecord, musicRecord1) => musicRecord1.Id - musicRecord.Id);
            return musicRecords;
        }

        //public void Delete(int id)
        //{
        //    MusicRecord musicrecord = _musicRecords.Find(musicrecord => musicrecord.Id == id);
        //    if (musicrecord == null) return;
        //    _musicRecords.Remove(musicrecord);
        //}

        //public void Add(MusicRecord value)
        //{
        //    value.Id = _nextId++;
        //    _musicRecords.Add(value);
        //}
    }
}

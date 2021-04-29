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
            new Album {Id = _nextAlbumId++, Title = "Beliber", Songs = 12,
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
            new Album
            {
                Id = _nextAlbumId++, Title = "RHCP", Songs = 2,
                MusicRecord = new List<MusicRecord>
                {
                    new MusicRecord{Id = _nextId++, Title = "Otherside", Artist = "Red Hot Chili Peppers", DurationInSec = 200, YearOfPublication = 2006, AlbumId = _nextAlbumId-1},
                    new MusicRecord{Id = _nextId++, Title = "Dani California", Artist = "Red Hot Chili Peppers", DurationInSec = 230, YearOfPublication = 2007, AlbumId = _nextAlbumId-1}
                }
            }
            
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

        public Album Add(Album album)
        {
            album.Id = _nextAlbumId++;
            _albums.Add(album);
            return album;
        }

        public MusicRecord AddMusicRecord(int AlbumId ,MusicRecord musicRecord)
        {
            Album album = _albums.Find(a => a.Id == AlbumId);
            if (album == null) return null;
            musicRecord.Id = _nextId++;
            musicRecord.AlbumId = album.Id;
            album.MusicRecord.Add(musicRecord);
            return musicRecord;

        }
    }
}

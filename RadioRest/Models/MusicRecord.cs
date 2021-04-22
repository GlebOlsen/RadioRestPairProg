using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadioRest.Models
{
    public class MusicRecord
    {
        private int _id;
        private string _title;
        private string _artist;
        private int _durationInSec;
        private int _yearOfPublication;
        private int _albumId;

        public int AlbumId
        {
            get => _albumId;
            set { _albumId = value; }
        }

        public int Id
        {
            get => _id;
            set { _id = value; }
        }

        public string Title
        {
            get => _title;
            set { _title = value; }
        }
        public string Artist
        {
            get => _artist;
            set { _artist = value; }
        }
        public int DurationInSec
        {
            get => _durationInSec;
            set { _durationInSec = value; }
        }
        public int YearOfPublication
        {
            get => _yearOfPublication;
            set { _yearOfPublication = value; }
        }

        public MusicRecord(int id,string title, string artist, int duration, int year, int albumId)
        {
            Id = id;
            Title = title;
            Artist = artist;
            DurationInSec = duration;
            YearOfPublication = year;
            AlbumId = albumId;
        }

        public MusicRecord()
        {

        }
    }
}

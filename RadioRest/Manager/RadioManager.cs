using RadioRest.Models;
using System.Collections.Generic;


namespace RadioRest.Manager
{
    public class RadioManager
    {
        private static int _nextId = 1;

        private static List<MusicRecord> _musicRecords = new List<MusicRecord>()
        {
            new MusicRecord(_nextId++,"Baby Oh","Justin Biber",250,2009),
            new MusicRecord(_nextId++,"I gotta feeling","Black Eye Peace",230,2009)
        };

        public List<MusicRecord> GetAll()
        {
            return _musicRecords;
        }

        public MusicRecord GetById(int id)
        {
            return _musicRecords.Find(musicrecord => musicrecord.Id == id);
        }

        public void Delete(int id)
        {
            MusicRecord musicrecord = _musicRecords.Find(musicrecord => musicrecord.Id == id);
            if (musicrecord == null) return;
            _musicRecords.Remove(musicrecord);
        }

        public void Add(MusicRecord value)
        {
            value.Id = _nextId++;
            _musicRecords.Add(value);
        }
    }
}

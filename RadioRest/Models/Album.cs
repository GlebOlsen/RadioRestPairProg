using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadioRest.Models
{
    public class Album
    {
        public List<MusicRecord> MusicRecord { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public int Songs { get; set; }
    }
}

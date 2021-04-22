using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RadioRest.Models;

namespace RadioRest.Manager
{
    public interface IAlbumsManager
    {
        List<Album> GetAllAlbums(string sange = null);
    }
}

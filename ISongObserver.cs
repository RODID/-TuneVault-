using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Library
{
    public interface ISongObserver
    {
        void UpdateSong(ISong song);
    }
}

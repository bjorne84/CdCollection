using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CdCollection.Models
{
    public class Cd
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Tracks { get; set; }
        public int Lenght { get; set; }

        // Navigation properties
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

    }

}

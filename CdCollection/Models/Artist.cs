using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CdCollection.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }


        //Navigation properties
        public List <Cd> Cds{ get; set; }
    }
}

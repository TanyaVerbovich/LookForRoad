using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookForRoad.Data.Models
{
    public class Road
    {
        public int id { set; get; }
        public string Name { set; get; }
        public int HowManyPlaces{ set; get; }
        public string place { set; get; }
        public DateTime datafrom { get; set; }
        public ushort Price { set; get; }
        public long Telephone { set; get; }
        public bool isFav { get; set; }

    }
}

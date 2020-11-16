using LookForRoad.Data.Interfaces;
using LookForRoad.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookForRoad.Data.Repository
{
    public class RoadRepository : IRoads
    {

        private readonly AppDBContent appDBContent;
        public RoadRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Road> Road => appDBContent.Road;

        public IEnumerable<Road> getFavRoad => appDBContent.Road.Where(p => p.isFav);
        public Road getObjectRoad(int Roadid) => appDBContent.Road.FirstOrDefault(p => p.id == Roadid);
    }
}

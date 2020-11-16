using LookForRoad.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookForRoad.ViewModels
{
    public class RoadsListViewModel
    {
        public IEnumerable<Road> GetRoads { get; set; }
    }
}

using LookForRoad.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookForRoad.Data.Interfaces
{
    public interface IRoads
    {
        IEnumerable<Road> Road { get;  }
        IEnumerable<Road> getFavRoad { get;  }
        Road getObjectRoad(int Roadid);
    }
}

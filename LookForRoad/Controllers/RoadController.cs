using Microsoft.AspNetCore.Mvc;
using LookForRoad.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LookForRoad.ViewModels;

namespace LookForRoad.Controllers
{
    public class RoadController : Controller
    {
        private readonly IRoads _allroads;

        public RoadController(IRoads iroads) 
        {
            _allroads = iroads;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Все маршруты";
            RoadsListViewModel obj = new RoadsListViewModel();
            obj.GetRoads = _allroads.Road;
            return View(obj);
        }
    }

}

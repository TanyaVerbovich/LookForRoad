using LookForRoad.Data.Interfaces;
using LookForRoad.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookForRoad.Data.Mocks
{
    public class MockRoad : IRoads
    {
        public IEnumerable<Road> Road 
        { get 
            {
                return new List<Road>
                {
                    new Road {
                        Name="Витебск-Минск",
                        HowManyPlaces = 2,
                        place="Площадь Победы",
                        datafrom = DateTime.Now,
                        Telephone= 375299874556,
                        isFav=true, 
                        Price=9},
                    new Road{
                        Name="Скидель-Гродно",
                        HowManyPlaces=1,
                        place="Улица Ленина",
                        datafrom = DateTime.Now,
                        Telephone=375256557080,
                        isFav = false,
                        Price = 5
                    },
                    new Road
                    {
                        Name="Браслав-Миоры",
                        HowManyPlaces=3,
                        place="Вокзал",
                        datafrom=DateTime.Now,
                        Telephone = 375334555600,
                        isFav=true,
                        Price=3
                    },
                    new Road{
                        Name="Минск-Гомель",
                        HowManyPlaces=1,
                        Telephone = 3752512230067,
                        place="Плозадь Якуба Коласа",
                        datafrom=DateTime.Now,
                        isFav=false,
                        Price=10
                    }

                };
            }
             }
        public IEnumerable<Road> getFavRoad { get ; set ; }

        public Road getObjectRoad(int Roadid)
        {
            throw new NotImplementedException();
        }
    }
}

using LookForRoad.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookForRoad.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            //AppDBContent content;
            //using (var scope = app.ApplicationServices.CreateScope())
            //{
            //    content = scope.ServiceProvider.GetRequiredService<AppDBContent>();

            //}
            if (!content.Road.Any())
            {
                content.AddRange(
                     new Road
                     {
                         Name = "Витебск-Минск",
                         HowManyPlaces = 2,
                         place = "Площадь Победы",
                         datafrom = DateTime.Now,
                         Telephone = 375299874556,
                         isFav = true,
                         Price = 9
                     },
                    new Road
                    {
                        Name = "Скидель-Гродно",
                        HowManyPlaces = 1,
                        place = "Улица Ленина",
                        datafrom = DateTime.Now,
                        Telephone = 375256557080,
                        isFav = false,
                        Price = 5
                    },
                    new Road
                    {
                        Name = "Браслав-Миоры",
                        HowManyPlaces = 3,
                        place = "Вокзал",
                        datafrom = DateTime.Now,
                        Telephone = 375334555600,
                        isFav = true,
                        Price = 3
                    },
                    new Road
                    {
                        Name = "Минск-Гомель",
                        HowManyPlaces = 1,
                        Telephone = 3752512230067,
                        place = "Площадь Якуба Коласа",
                        datafrom = DateTime.Now,
                        isFav = false,
                        Price = 10
                    }
);
                content.SaveChanges();
            }
        }
    }
}

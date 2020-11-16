using Microsoft.EntityFrameworkCore;
using LookForRoad.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookForRoad.Data
{
    public class AppDBContent:DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }
        public DbSet<Road> Road { get; set; }

    }
}

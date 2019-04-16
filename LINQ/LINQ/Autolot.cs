using System;
using System.Data.Entity;
using System.Linq;
namespace LINQ
{
    public class Autolot : DbContext
    {
        public Autolot()
            : base("name=Autolot")
        {
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Mark> Marks { get; set; }
    }


}
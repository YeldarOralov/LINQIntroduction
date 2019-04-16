using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Autolot())
            {
                //var mark = new Mark
                //{
                //    Name = "Subaru"
                //};
                //context.Marks.Add(mark);
                //context.Cars.Add(new Car { Mark = mark, Name = "Impreza", Price = 20000, Color = "Red" });
                //context.SaveChanges();

                var marksWithT = from mark
                                 in context.Marks
                                 where mark.Name.ToLower().Contains("t")
                                 orderby mark.Name
                                 ascending
                                 select mark;

                var cars = marksWithT.Where(x => x.Cars.Count > 0)
                    .OrderBy(x => x.Name)
                    .FirstOrDefault();

                var name = "Oleg";
                int count = name.GetCount(); //look at string extention
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MenuLesson
{
    public class DataInitializer :CreateDatabaseIfNotExists<CarsContext>
    {
        protected override void Seed(CarsContext context)
        {
            context.Cars.AddRange(new List<Car>
            {
                new Car
                {
                    Name="Lexus",
                    Color="Silver",
                    Price=8000
                },

                new Car
                {
                    Name="Maybach",
                    Color="Baklajan",
                    Price=10000
                }
            });
            base.Seed(context);
        }
    }
}

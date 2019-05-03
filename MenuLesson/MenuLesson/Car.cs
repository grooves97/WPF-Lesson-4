using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLesson
{
    public class Car
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Name},{Color},{Price}";
        }

    }
}

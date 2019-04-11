using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Measurement
    {
        public DateTime Date { get; set; }
        public int Value { get; set; }

        public static List<Measurement> GetDummyData()
        {
            return new List<Measurement>
            {
                new Measurement {Date = new DateTime(2019, 4, 1), Value = 17},
                new Measurement {Date = new DateTime(2019, 4, 2), Value = 7},
                new Measurement {Date = new DateTime(2019, 4, 3), Value = 1},
                new Measurement {Date = new DateTime(2019, 4, 4), Value = 10},
                new Measurement {Date = new DateTime(2019, 4, 5), Value = 5},
                new Measurement {Date = new DateTime(2019, 4, 6), Value = 8},
                new Measurement {Date = new DateTime(2019, 4, 7), Value = 9},
            };

        }
    }
}

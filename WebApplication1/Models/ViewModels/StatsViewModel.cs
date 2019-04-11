using System;
using System.Collections.Generic;

namespace WebApplication1.Models.ViewModels
{
    public class StatsViewModel
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public List<Measurement> Data { get; set; }
    }
}

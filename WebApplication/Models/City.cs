using System;

namespace WebApplication.Models
{
    public class City
    {
        public string Name { get; set; }
        public Guid Guid { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
    
}
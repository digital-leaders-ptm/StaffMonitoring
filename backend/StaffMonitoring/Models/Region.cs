using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffMonitoring.Models
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Coefficient { get; set; }

        public Region(int id, string name, double coefficient)
        {
            Id = id;
            Name = name;
            Coefficient = coefficient;
        }

        public Region()
        {
        }
    }
}

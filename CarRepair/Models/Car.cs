using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRepair.Models
{
    public class Car
    {
        public string LicensePlate { get; set; }
        public string OwnerName { get; set; }
        public string OwnerAddress { get; set; }
        public int Make { get; set; }
        public string Model { get; set; }

        public bool Doors { get; set; }
        public bool Electric { get; set; }
        public bool WD {get;set;}
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Company
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int vehiclesNumber { get; set; }
        public int CompanyPoint { get; set; }

        public virtual List<Customer> Customers { get; set; }
        public virtual List<VehicleInformation> VehicleInformations { get; set; }




    }
}

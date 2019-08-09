using OpenClosedPrincipleDemo.Contracts;
using OpenClosedPrincipleDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleDemo.Filters
{
    public class VehicleFilter:IFilter<Vehicle>
    {
        public List<Vehicle> Filter(IEnumerable<Vehicle> vehicles, ISpecification<Vehicle> specification)
        {
            return vehicles.Where(v => specification.IsSatisified(v)).ToList();
        }
    }
}

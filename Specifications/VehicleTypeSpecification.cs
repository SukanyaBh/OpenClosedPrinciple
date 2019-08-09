using OpenClosedPrincipleDemo.Contracts;
using OpenClosedPrincipleDemo.Enums;
using OpenClosedPrincipleDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleDemo.Specifications
{
    public class VehicleTypeSpecification:ISpecification<Vehicle>
    {
        public VehicleType _type { get; set; }

        public VehicleTypeSpecification(VehicleType type)
        {
            this._type = type;
        }

        public bool IsSatisified(Vehicle vehicle)
        {
            return vehicle.Type == this._type;
        }
    }
}

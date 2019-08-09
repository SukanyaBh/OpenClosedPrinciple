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
    public class MonitorTypeSpecification:ISpecification<ComputerMonitor>
    {
        public MonitorType _type { get; set; }

        public MonitorTypeSpecification(MonitorType type)
        {
            this._type = type;
        }

        public bool IsSatisified(ComputerMonitor monitor)
        {
            return monitor.Type == this._type;
        }
    }
}

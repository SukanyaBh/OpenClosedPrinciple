using OpenClosedPrincipleDemo.Contracts;
using OpenClosedPrincipleDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleDemo.Filters
{
    public class MonitorFilter:IFilter<ComputerMonitor>
    {
        public List<ComputerMonitor> Filter(IEnumerable<ComputerMonitor> monitors, ISpecification<ComputerMonitor> specification)
        {
            return monitors.Where(m => specification.IsSatisified(m)).ToList();
        }
    }
}

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
    public class ScreenTypeSpecification:ISpecification<ComputerMonitor>
    {
        public ScreenType _screenType { get; set; }

        public ScreenTypeSpecification(ScreenType screenType)
        {
            this._screenType = screenType;
        }

        public bool IsSatisified(ComputerMonitor monitor)
        {
            return monitor.Screen == this._screenType;
        }
    }
}

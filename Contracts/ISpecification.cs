using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipleDemo.Contracts
{
    public interface ISpecification<T>
    {
        bool IsSatisified(T item);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceContravariance
{
    internal interface ICovariant<out T>
    {
        T Produce();
    }
}

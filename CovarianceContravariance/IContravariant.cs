using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceContravariance
{
    internal interface IContravariant<in T> where T : notnull
    {
        int GetCode(T t);
    }
}

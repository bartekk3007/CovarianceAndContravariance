using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceContravariance
{
    internal class ContravariantClass<T> : IContravariant<T> where T : notnull
    {
        public int GetCode(T t)
        {
            return t.GetHashCode();
        }
        public ContravariantClass()
        {

        }
    }
}

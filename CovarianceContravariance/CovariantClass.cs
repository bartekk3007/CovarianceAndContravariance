using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceContravariance
{
    internal class CovariantClass<T> : ICovariant<T>
    {
        T Value {  get; set; }
        public CovariantClass(T value)
        {
            Value = value;
        }
        public T Produce()
        {
            return Value;
        }
    }
}

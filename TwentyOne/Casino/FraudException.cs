using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception //inheriting from exception, all specific exceptions will inherit from exceptions: a form of polymorphism.
    {
        public FraudException() //standard constructor
            : base() {} //inheriting from base Exception
        public FraudException(string message) //overloading constructor method
        : base(message) { } 
    }
}

using System;
using System.Runtime.Serialization;

namespace NSubstitute.Exceptions
{
    [DataContract]
    public class ArgumentNotFoundException : SubstituteException
    {
        public ArgumentNotFoundException(string message) : base(message) { }
        //protected ArgumentNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}

using System;
using System.Runtime.Serialization;

namespace NSubstitute.Exceptions
{
    [DataContract]
    public class MissingSequenceNumberException : SubstituteException
    {
        public MissingSequenceNumberException() { }
        //protected MissingSequenceNumberException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}

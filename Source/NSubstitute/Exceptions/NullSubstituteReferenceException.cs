using System;
using System.Runtime.Serialization;

namespace NSubstitute.Exceptions
{
    [DataContract]
    public class NullSubstituteReferenceException : NotASubstituteException 
    {
        public NullSubstituteReferenceException() { }
        //protected NullSubstituteReferenceException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}

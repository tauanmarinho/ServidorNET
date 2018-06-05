using System;

namespace GitBuild.Domain 
{
    public class DomainException : Exception
    {
        public DomainException(string error)
        {

        }
        public static void When(bool valid, string error)
        {
            if(!valid)
                throw new DomainException(error);
        }
    }
}
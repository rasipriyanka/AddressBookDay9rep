using System;
using System.Collections.Generic;
using System.Text;
//----Namespace--------//
namespace AddresBookSystem
{
    public class CustomException:Exception
    {
        public ExceptionType type;
        public enum ExceptionType//type of exception
        {
            Duplicate_Exception,
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

    }
}


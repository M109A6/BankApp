using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class NSFException: Exception
    {
        //Constructor
        //Pass nothing
        public NSFException() : base()
        {

        }

        //pass message
        public NSFException(string message) : base(message)
        {

        }
    }
}

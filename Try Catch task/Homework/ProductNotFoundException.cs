using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class ProductNotFoundException:Exception
    {
        public ProductNotFoundException(string message):base(message) 
        {

        }
    }
}

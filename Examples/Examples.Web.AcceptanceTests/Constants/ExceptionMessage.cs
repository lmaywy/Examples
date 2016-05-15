using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Web.AcceptanceTests.Constants
{
    public class ExceptionMessage
    {
        public const string ElementNotFound = "No element found with selector {0}";
        public const string MutipleElementsFound = "Multiple elements found with selector {0}. Make sure that the selector uniquely identifies a single element.";
    }
}

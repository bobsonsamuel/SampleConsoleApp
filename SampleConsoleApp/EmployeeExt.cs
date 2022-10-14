using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsoleApp
{
    static class EmployeeExt
    {
        public static bool IsActive(this Employee empe)
        {
            return true;
        }

        public static bool HasCard(this IEmployee empe, Employee empeValue)
        {
            return false;
        }
    }
}

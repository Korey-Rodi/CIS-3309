using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Demo
{
    // Internal any class within the same project
    // Protected any class anywhere as long as it is a descendant of the same class
    //Public static lets you share it
    internal class GlobalSharedData
    {
        public static Car theCar = new Car();
        public static String message = "CIS 3309 Shared Data";

    }
}

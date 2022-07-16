using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ItemsManager.WPF.Helpers
{
    public class IsResourceExists
    {
        // Member Variable
        static public string[] resourceNames;

        // Function
        static public Boolean ResourceExists(string resourceName)
        {
            
                resourceNames =
                    Assembly.GetExecutingAssembly().GetManifestResourceNames();
            

            return resourceNames.Contains(resourceName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace NorthwindHost
{
    static class Program
    {   
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
			{ 
				new ServiceHosts() 
			};
            ServiceBase.Run(ServicesToRun);
        }
    }
}

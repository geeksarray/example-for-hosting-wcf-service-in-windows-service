using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace NorthwindHost
{
    public partial class ServiceHosts : ServiceBase
    {
        public ServiceHosts()
        {
            InitializeComponent();
            ServiceName = "Northwind Services";
        }

        protected override void OnStart(string[] args)
        {
            ProductServiceHost.Start();  
        }

        protected override void OnStop()
        {
            ProductServiceHost.Stop();
        }
    }
}

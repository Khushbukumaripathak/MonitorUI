using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SCM_TF.Monitoring;
using SCM_TF.Database;

namespace MonitoringWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //WebHost.CreateDefaultBuilder(args)
        //    .UseStartup<Startup>();

        WebHost.CreateDefaultBuilder(args)
            .UseUrls("https://localhost:5001;http://localhost:5000")
            .UseStartup<Startup>();

    }
}

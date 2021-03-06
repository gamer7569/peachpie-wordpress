﻿using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace peachserver
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()) + "/website";

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseWebRoot(root)
                .UseContentRoot(root)
                .UseUrls("http://*:5004/")
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}

﻿using Nancy.Hosting.Self;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //修改 one  two  three four five  忽略
            using (var host = new NancyHost(new Uri("http://localhost:9001")))
            {
                host.Start();
                Console.ReadLine();
            }
        }
    }
}

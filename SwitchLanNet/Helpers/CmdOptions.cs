using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CommandLine;

namespace SwitchLanNet.Helpers
{
    public class CmdOptions
    {
        [Option("ip", Required = false, HelpText = "IP to listen on, default was 127.0.0.1(localhost).", Default = "0.0.0.0")]
        public string Address { get; set; }

        [Option('p', "port", Required = false, Default = 11451, HelpText = "Port to listen on(default 11451)")]
        public int Port { get; set; }
    }
}

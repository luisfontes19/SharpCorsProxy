using CommandLine;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsProxy
{
    class Program
    {

        public static String SERVER_ADDRESS = "127.0.0.1";
        public static int SERVER_PORT = 19191;
        public static int TIMEOUT = 30;
        public static bool KEEP_USER_AGENT = false;

        public class Options
        {
            [Option('a', "address", Required = false, HelpText = "Address to bind the proxy to", Default = "127.0.0.1")]
            public String Address { get; set; }

            [Option('p', "port", Required = false, HelpText = "Port on which to run the proxy", Default = 19191)]
            public int Port{ get; set; }

            [Option('t', "timeout", Required = false, HelpText = "Number os seconds to wait for a response", Default = 30)]
            public int Timeout { get; set; }

            [Option('k', "keep-user-agent", Required = false, HelpText = "Keep User Agent", Default = false)]
            public bool KeepUserAgent { get; set; }

        }


        static void Main(string[] args)
        {

            Parser.Default.ParseArguments<Options>(args).WithParsed<Options>(o =>
            {
            

                SERVER_ADDRESS = o.Address;
                SERVER_PORT = o.Port;
                TIMEOUT = o.Timeout;
                KEEP_USER_AGENT = o.KeepUserAgent;

                String addr = "http://" + SERVER_ADDRESS + ":" + SERVER_PORT;
                Console.WriteLine("Starting webserver at " + addr);
                WebApp.Start<Startup>(url: addr);

                while (true) ;

            });


        }
    }
}

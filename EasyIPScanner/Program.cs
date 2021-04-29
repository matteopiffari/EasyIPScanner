using System;
using System.Text;
using System.Net.NetworkInformation;
using System.Threading;

namespace EasyIPScanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Network (example: 192.168.1): ");
            string net = Console.ReadLine();
            Console.WriteLine("Scan in progess...");
            Console.WriteLine("");
            Console.WriteLine("Online IP:");
            Console.WriteLine("");
            Thread.Sleep(1000);

            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            options.DontFragment = true;

            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 65;
            int i = 0;
            while (i < 255)
            {
                string IP = net + "." + i;
                PingReply reply = pingSender.Send(IP, timeout, buffer, options);
                if (reply.Status == IPStatus.Success)
                {
                    Console.WriteLine("IP " + reply.Address.ToString() + " Time: " + reply.RoundtripTime + " ms" + " ttl: " + reply.Options.Ttl);
                }
                i++;
            }

            Console.WriteLine("");
            Console.WriteLine("Scan finished, press a key to close");
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;

namespace Basic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // context: The gaming store has many online consulting channels. If any consultation request to the store,
            //          they will be considered and redirected to the channels that are available.

            Console.WriteLine("Hello World!");
            string req = "";
            var singleChannel = new ConsultingChannel(99);
            var proxy = new ConsultingChannelProxy(new List<IConsulatingChannel>()
            {
                new ConsultingChannel(1),
                new ConsultingChannel(2),
                new ConsultingChannel(3),
                new ConsultingChannel(4),
            });
            do
            {
                Console.WriteLine("Please type a request");
                req = Console.ReadLine();
                HandleConsultingRequest(req, proxy);
            } while (!req.Equals("stop", StringComparison.CurrentCultureIgnoreCase));

            Console.ReadKey();
        }

        static void HandleConsultingRequest(string request, IConsulatingChannel channel)
        {
            channel.HandleRequest(request);
        }
    }
}

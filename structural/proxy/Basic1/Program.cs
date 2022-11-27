using System;

namespace Basic1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // context: The gaming store has many online consulting channels. If any consultation request to the store,
            //          they will be considering and checking before receive the request.

            var channelService = new ConsultedChannelService();
            var proxy = new ConsultedChannelProxy(channelService);

            ReceivedRequest("I fucking to build a new gaming pc", proxy);
            Console.WriteLine("Hello World!");
        }

        static void ReceivedRequest(string request, IConsultation consultation)
        {
            Console.WriteLine(request);
            consultation.Request(request);
        }
    }
}

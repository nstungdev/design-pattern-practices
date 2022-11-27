using System;
using System.Collections.Generic;
using System.Text;

namespace Basic1
{
    public class ConsultedChannelService : IConsultation
    {
        public void Request(string request)
        {
            Console.WriteLine("Received a request");
            Console.WriteLine("Content: " + request);
        }
    }
}

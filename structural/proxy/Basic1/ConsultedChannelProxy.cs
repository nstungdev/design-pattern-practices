using System;
using System.Collections.Generic;
using System.Text;

namespace Basic1
{
    public class ConsultedChannelProxy : IConsultation
    {
        readonly ConsultedChannelService _service;
        public ConsultedChannelProxy(ConsultedChannelService service)
        {
            _service = service;
        }
        public void Request(string request)
        {
            if (request.Contains("want to"))
            {
                _service.Request(request);
            }
            else
            {
                Console.WriteLine("Denied request");
            }
        }
    }
}

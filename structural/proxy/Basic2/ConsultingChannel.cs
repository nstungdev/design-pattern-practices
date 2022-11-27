using System;
using System.Collections.Generic;
using System.Text;

namespace Basic2
{
    public class ConsultingChannel : IConsulatingChannel
    {
        int _channelCode;
        public ConsultingChannel(int channelCode)
        {
            _channelCode = channelCode;
        }
        public void HandleRequest(string request)
        {
            Console.WriteLine($"I received a request -- {_channelCode}");
        }

        public bool IsFree()
        {
            var rd = new Random();
            var value = rd.Next(0, 10);
            return value > 5;
        }
    }
}

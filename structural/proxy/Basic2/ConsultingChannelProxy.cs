using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic2
{
    public class ConsultingChannelProxy : IConsulatingChannel
    {
        readonly IEnumerable<IConsulatingChannel> _channels;
        int _cachedOrderNr = 0;
        public ConsultingChannelProxy(IEnumerable<IConsulatingChannel> channels)
        {
            var elementChecks = channels.FirstOrDefault(e => e.GetType() == typeof(ConsultingChannelProxy));
            if (elementChecks != null)
                throw new InvalidOperationException("Invalid element of type");
            _channels = channels;
        }
        //public void HandleRequest(string request)
        //{
        //    var targetChannel = _channels.ElementAt(_cachedOrderNr);
        //    targetChannel.HandleRequest(request);
        //    IncreaseOrderNr();
        //}

        public void HandleRequest(string request)
        {
            var targetChannel = _channels.Where(e => e.IsFree()).FirstOrDefault();
            if (targetChannel == null)
            {
                Console.WriteLine("Please retry after 1 minutes");
            }
            else
            {
                targetChannel.HandleRequest(request);
            }
        }

        public bool IsFree()
        {
            return _channels.Any(e => e.IsFree());
        }

        private void IncreaseOrderNr()
        {
            _cachedOrderNr++;
            if (_cachedOrderNr == _channels.Count())
                _cachedOrderNr = 0;
        }
    }
}

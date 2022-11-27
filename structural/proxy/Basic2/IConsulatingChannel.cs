using System;
using System.Collections.Generic;
using System.Text;

namespace Basic2
{
    public interface IConsulatingChannel
    {
        void HandleRequest(string request);
        bool IsFree();
    }
}

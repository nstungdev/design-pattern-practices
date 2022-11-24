using System;
using System.Collections.Generic;
using System.Text;

namespace Basic1
{
    public class GamingPcBuilder
    {
        GamingPc _gamingPc = new GamingPc();
        public void SetRam(string ram)
        {
            _gamingPc.RAM = ram;
        }

        public void SetRom(string rom)
        {
            _gamingPc.ROM = rom;
        }

        public void SetCPU(string card, string chip)
        {
            _gamingPc.Card = card;
            _gamingPc.Chip = chip;
        }

        public void Reset()
        {
            this._gamingPc = new GamingPc();
        }

        public GamingPc Build()
        {
            return _gamingPc;
        }
    }
}

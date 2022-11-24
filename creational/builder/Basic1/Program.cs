using System;

namespace Basic1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // description: The ST gaming store. The customers come to the store, they will chose for themselves the appropriate
            //              gaming computer components () and then build themselves gaming pc.

            var gamingPcBuilder = new GamingPcBuilder();
            gamingPcBuilder.SetRam("16GB");
            gamingPcBuilder.SetRom("500GB");
            gamingPcBuilder.SetCPU("GFX 1200", "Intel i5 10000F");
            var gamingPc = gamingPcBuilder.Build();
            gamingPc.PrintGamingInfo();

            gamingPcBuilder.Reset();

            gamingPc = gamingPcBuilder.Build();

            gamingPc.PrintGamingInfo();


            Console.WriteLine("Hello World!");
        }
    }
}

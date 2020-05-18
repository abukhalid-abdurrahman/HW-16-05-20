/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Open/Closed Principle (Render Type Interface: Realtime)
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */
using System;
namespace Day_23
{
    class RealtimeRender : IRenderType
    {
        public void Render()
        {
            Console.WriteLine("Rendering In Realtime");
        }
    }
}

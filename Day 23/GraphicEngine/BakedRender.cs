/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Open/Closed Principle (Render Type Interface: Baked)
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */
using System;
namespace Day_23
{
    class BakedRender : IRenderType
    {
        public void Render()
        {
            Console.WriteLine("Baked Data Are Rendered");
        }
    }
}

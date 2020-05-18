/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Dependency Inversion Principle
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */
using System;

namespace Day_23
{
    class Direct3DAPI : IGraphicAPI
    {
        public void InitAPI()
        {
            Console.WriteLine("Graphic API: Direct3D");
        }
    }
}

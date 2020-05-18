/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Dependency Inversion Principle
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */
using System;

namespace Day_23
{
    class OpenGLAPI : IGraphicAPI
    {
        public void InitAPI()
        {
            Console.WriteLine("Graphic API: OpenGL");
        }
    }
}

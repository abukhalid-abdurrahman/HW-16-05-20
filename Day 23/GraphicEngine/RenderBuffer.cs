/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Single Responsibility Princilpe (RenderBuffer Class)
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */
using System;
namespace Day_23
{
    class RenderBuffer
    {
        public void Render(IScene scene)
        {
            Console.WriteLine($"Rendering Scene {scene.Name} --> Successfully");
        }
    }
}

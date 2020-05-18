/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Single Responsibility Princilpe (RenderBuffer Class)
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */
using System;
namespace Day_23
{
    class RenderBuffer : IRender
    {
        public void Render(IScene scene, IRenderType renderType)
        {
            renderType.Render();
            Console.WriteLine($"Rendering Scene {scene.Name} --> Successfully");
        }
    }
}

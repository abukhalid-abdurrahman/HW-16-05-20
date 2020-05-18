/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Single Responsibility Princilpe (Scene Creation Class)
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */

using System;
using System.Collections.Generic;
namespace Day_23
{
    class Scene : IScene
    {
        public string Name { get; set; }
        public string FilePath { get; set; }
        private List<Vertex> sceneVertices;
        public Scene()
        {
            sceneVertices = new List<Vertex>();
        }

        public void CreateScene()
        {
            Console.WriteLine($"Scene Stream {Name} Created --> Successfully");
        }

        public void CloseScene()
        {
            Console.WriteLine($"Scene Stream {Name} Closed --> Successfully");
        }

        public void SaveScene()
        {
            Console.WriteLine($"Create Stream {FilePath}...");
            Console.WriteLine($"Writing {sceneVertices.Count} Vertices From {Name} To {FilePath}...");
            Console.WriteLine($"Closing Stream {FilePath}...");
            Console.WriteLine($"Scene {Name} With {sceneVertices.Count} Saved --> Successfully");
        }

        public void LoadScene(List<Vertex> vertices)
        {
            Console.WriteLine($"Create Stream {FilePath}...");
            Console.WriteLine($"Copieng  Vertices From ({vertices} - Loaded Vertices) To ({sceneVertices} - Scene Vertices)...");
            Console.WriteLine($"Closing Stream {FilePath}...");
            Console.WriteLine($"Scene {FilePath} With {vertices.Count} Loaded --> Successfully");
        }
    }
}

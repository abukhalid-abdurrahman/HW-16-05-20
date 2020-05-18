/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Single Responsibility Princilpe (Scene Creation Interface)
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */
using System.Collections.Generic;
namespace Day_23
{
    interface IScene
    {
        string Name { get; set; }
        void CreateScene();
        void CloseScene();
        void SaveScene();
        void LoadScene(List<Vertex> vertices);
    }
}

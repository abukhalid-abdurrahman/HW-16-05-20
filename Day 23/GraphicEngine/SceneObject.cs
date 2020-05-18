/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 *(Liskov Substitution Principle (Scene Object)
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */
using System.Collections.Generic;

namespace Day_23
{
    class SceneObject
    {
        public List<Vertex> objectVertices;
        public Vector3 objectPosition;
        public string Name { get; set; }
    }
}

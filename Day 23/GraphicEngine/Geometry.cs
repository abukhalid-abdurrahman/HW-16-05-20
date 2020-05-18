/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 *(Liskov Substitution Principle (Scene Geometry Object)
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */
using System;

namespace Day_23
{
    class Geometry : SceneObject , IObject
    {
        public string GeometryType { get; set; }
        public void Push()
        {
            Console.WriteLine($"{this.Name} Geometry Object (Type: {GeometryType.ToUpper()}), Was Added --> Successfully");
        }
    }
}

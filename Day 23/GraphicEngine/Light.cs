/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 *(Liskov Substitution Principle (Scene Light Object)
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */
using System;

namespace Day_23
{
    struct Color
    {
        public int R;
        public int G;
        public int B;
    }
    class Light : SceneObject , IObject
    {
        public int LightIntesivity { get; set; }
        private string LightType { get; set; }
        public Color LightColor { get; set; }
        public void Push()
        {
            Console.WriteLine($"{this.Name} Light Object (Type: {LightType.ToUpper()}, Color(R: {LightColor.R}, G: {LightColor.G}, B: {LightColor.B})), Was Added --> Successfully");
        }
    }
}

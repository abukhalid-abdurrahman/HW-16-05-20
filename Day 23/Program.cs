using System;

namespace Day_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alif 3D - Game Engine");

            GraphicRenderer graphicRenderer = new GraphicRenderer(new OpenGLAPI());
            graphicRenderer.InitRenderer();

            Scene scene = new Scene();
            scene.Name = "Intro";
            scene.FilePath = "/scenes/level01.scn";
            scene.CreateScene();

            Light light = new Light();
            light.Name = "Ambient Light";
            light.objectPosition = new Vector3 { X = 0, Y = 0, Z = 0 };
            light.LightColor = new Color { R = 0, G = 0, B = 0 };
            light.LightType = "Ambient";
            light.LightIntesivity = 1;
            light.Push();
            
            Geometry geometry = new Geometry();
            geometry.GeometryType = "Triangle";
            geometry.Name = "Ground";
            geometry.objectPosition = new Vector3 { X = 0, Y = 1, Z = 0 };
            Vertex vertex1;
            vertex1.Position.X = 0;
            vertex1.Position.Y = 0;
            vertex1.Position.Z = 0;
            Vertex vertex2;
            vertex2.Position.X = 1;
            vertex2.Position.Y = 0;
            vertex2.Position.Z = 0;
            Vertex vertex3;
            vertex3.Position.X = 1;
            vertex3.Position.Y = 1;
            vertex3.Position.Z = 0;
            geometry.objectVertices = new System.Collections.Generic.List<Vertex>();
            geometry.objectVertices.Add(vertex1);
            geometry.objectVertices.Add(vertex2);
            geometry.objectVertices.Add(vertex3);
            geometry.Push();
            scene.SaveScene();

            RenderBuffer renderBuffer = new RenderBuffer();
            renderBuffer.Render(scene, new BakedRender());

            MobileBuilder mobileBuilder = new MobileBuilder();
            mobileBuilder.BuildSystem = "Internal";
            mobileBuilder.GraphicAPI = "OpenGL ES v3.0";
            mobileBuilder.GraphicQuality = "LOW";
            mobileBuilder.InputType = "Sensor";
            mobileBuilder.Platform = "Android";
            mobileBuilder.TextureCompression = "ТСv02";
            mobileBuilder.Build(@"/build/");

            Console.Read();
        }
    }
}

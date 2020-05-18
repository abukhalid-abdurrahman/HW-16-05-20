/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Interface Segregation Principle (Computer Builder)
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */
using System;

namespace Day_23
{
    class ComputerBuilder : IComputerBuilder
    {
        public string Architecture { get; set; }

        public string GraphicAPI { get; set; }

        public string GraphicQuality { get; set; }

        public string InputType { get; set; }

        public string Platform { get; set; }

        public void Build(string rootPath)
        {
            Console.WriteLine($"Builded to Computer Device (Platform: {Platform}, Architecture {Architecture}, Graphic API {GraphicAPI}) --> Successfully");
        }
    }
}

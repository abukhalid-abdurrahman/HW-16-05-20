/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Interface Segregation Principle (Mobile Builder)
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */
using System;

namespace Day_23
{
    class MobileBuilder : IMobileBuilder
    {
        public string BuildSystem { get; set; }

        public string GraphicAPI { get; set; }

        public string GraphicQuality { get; set; }

        public string InputType { get; set; }

        public string Platform { get; set; }

        public string TextureCompression { get; set; }

        public void Build(string rootPath)
        {
            Console.WriteLine($"Builded to Mobile Device (Platform: {Platform}, Texture Compression {TextureCompression}, Graphic API {GraphicAPI}) --> Successfully");
        }
    }
}

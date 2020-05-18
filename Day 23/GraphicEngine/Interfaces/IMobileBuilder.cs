/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Interface Segregation Principle (Mobile Builder)
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */
namespace Day_23
{
    interface IMobileBuilder : IBuilder
    {
        string TextureCompression { get; set; }
        string BuildSystem { get; set; }
        string Platform { get; set; }
    }
}

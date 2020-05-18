/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Interface Segregation Principle (Builder)
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */
namespace Day_23
{
    interface IBuilder
    {
        string GraphicAPI { get; set; }
        string GraphicQuality { get; set; }
        string InputType { get; set; }
        void Build(string rootPath);
    }
}

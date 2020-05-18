/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Interface Segregation Principle (Computer Builder)
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */
namespace Day_23
{
    interface IComputerBuilder : IBuilder
    {
        string Architecture { get; set; }
        string Platform { get; set; }
    }
}

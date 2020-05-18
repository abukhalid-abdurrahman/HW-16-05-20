/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Single Responsibility Princilpe (Render Interface)
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */
namespace Day_23
{
    interface IRender
    {
        void Render(IScene scene, IRenderType renderType);
    }
}

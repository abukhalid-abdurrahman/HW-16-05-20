/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Dependency Inversion Principle
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */
using System;

namespace Day_23
{
    class GraphicRenderer
    {
        private IGraphicAPI graphicAPI;
        public GraphicRenderer(IGraphicAPI graphicAPI)
        {
            this.graphicAPI = graphicAPI;
        }
        public void InitRenderer()
        {
            graphicAPI.InitAPI();
        }
    }
}

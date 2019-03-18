namespace GraphicEditor
{
    using System;

    public class GraphicEditor
    {
        public void DrawShape(IShape shape)
        {
            Console.WriteLine($"I'm {shape.GetType().Name}");
        }
    }
}

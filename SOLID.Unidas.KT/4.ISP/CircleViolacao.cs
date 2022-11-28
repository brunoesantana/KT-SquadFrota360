using System;

namespace _4.ISP
{
    internal class CircleViolacao : IShapeViolacao
    {
        public string DrawCircle()
        {
            return "desenho círculo";
        }

        public string DrawRectangle()
        {
            throw new NotImplementedException();
        }

        public string DrawSquare()
        {
            throw new NotImplementedException();
        }

        public string DrowPentagon()
        {
            throw new NotImplementedException();
        }
    }
}
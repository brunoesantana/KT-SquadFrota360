using System;

namespace _4.ISP
{
    public class SquareViolacao : IShapeViolacao
    {
        public string DrawCircle()
        {
            throw new NotImplementedException();
        }

        public string DrawRectangle()
        {
            throw new NotImplementedException();
        }

        public string DrawSquare()
        {
            return "desenho quadrado";
        }

        public string DrowPentagon()
        {
            throw new NotImplementedException();
        }
    }
}
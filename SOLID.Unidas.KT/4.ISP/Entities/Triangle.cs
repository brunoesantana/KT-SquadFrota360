namespace _4.ISP
{
    public class Triangle : IShape, IDetail
    {
        public string Draw()
        {
            return "desenho triangulo";
        }

        public string Type()
        {
            return "escaleno";
        }
    }
}
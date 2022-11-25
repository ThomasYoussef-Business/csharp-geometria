namespace csharp_geometria {
    internal class Rectangle {
        public int width, height;
        public Rectangle(int width, int height) {
            this.width = width;
            this.height = height;
        }

        public int Area() => width * height;
        public int Perimeter() => width * 2 + height * 2;
    }
}

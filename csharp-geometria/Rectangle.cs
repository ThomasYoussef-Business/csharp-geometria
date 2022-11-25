namespace csharp_geometria {
    internal class Rectangle {
        public int width, height;
        public string? name;
        public Rectangle(int width, int height, string? name = null) {
            this.width = width;
            this.height = height;
            this.name = name;
        }

        public int Area() => width * height;
        public int Perimeter() => width * 2 + height * 2;
        public void PrintRectangle() {
            Console.WriteLine($"-- {name ?? "Rectangle"} --{Environment.NewLine}" + $"Width: {width} cm{Environment.NewLine}" + $"Height: {height} cm{Environment.NewLine}" + $"Area: {Area()} cm²{Environment.NewLine}" + $"Perimeter: {Perimeter()} cm{Environment.NewLine}" + $"");
        }
    }
}

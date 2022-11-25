using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_geometria;

namespace bonus {
    internal class RectangleBonus : Rectangle {
        public RectangleBonus(int width, int height, string? name = null) : base(width, height, name) {
        }

        public override void PrintRectangle() {
            Console.WriteLine(new string('—', width));
            for (int x = 0; x < height - 2; x++) {
                Console.WriteLine($"|{new string(' ', width - 2)}|");
            }
            Console.WriteLine(new string('—', width));
        }
    }
}

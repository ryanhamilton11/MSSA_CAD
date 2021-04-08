using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(-1, -2);
            r1.SetLength(2.0);
            r1.SetWidth(-0.1);

            Rectangle r2 = new Rectangle();
            r2.SetLength(3);
            r2.SetLength(-2);

            Rectangle r3 = new Rectangle();
            r3.SetLength(0);
            r3.SetWidth(0);
        }
    }
}

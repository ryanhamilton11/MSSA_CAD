using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(-1);
            c1.SetRadius(2.0);

            Circle c2 = new Circle();
            c2.SetRadius(3);

            Circle c3 = new Circle();
            c3.SetRadius(0);

            Rectangle r1 = new Rectangle(-1, -2);
            r1.SetLength(2.0);
            r1.SetWidth(-0.1);

            Rectangle r2 = new Rectangle();
            r2.SetLength(3);
            r2.SetLength(-2);

            Rectangle r3 = new Rectangle();
            r3.SetLength(0);
            r3.SetWidth(0);

            Square s1 = new Square(-1);
            s1.SetSide(2.0);

            Square s2 = new Square();
            s2.SetSide(3);

            Square s3 = new Square();
            s3.SetSide(0);

            Triangle t1 = new Triangle(0, 1, 2);
            t1.SetSideA(2.0);
            t1.SetSideB(0);
            t1.SetSideC(-0.2);


            Triangle t2 = new Triangle(-1, 0, 1);
            t1.SetSideA(12);
            t1.SetSideB(-0);
            t1.SetSideC(-21);

            Triangle t3 = new Triangle(-0, 0, 1);
            t1.SetSideA(0.0);
            t1.SetSideB(0.1);
            t1.SetSideC(-0.2);
        }
    }
}

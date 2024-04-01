namespace oop17
{
    abstract class Function
    {
        public abstract double Calculate(double x);
    }

    // Похідний клас Ellipse 
    internal class Ellipse : Function
    {

        private double h; // координата x центру еліпса
        private double k; // координата y центру еліпса
        private double a; // довжина напіввісі по горизонталі
        private double b; // довжина напіввісі по вертикалі

        public Ellipse(double h, double k, double a, double b)
        {
            if (a == 0 || b == 0)
            {
                throw new ArgumentException("a або b не можуть бути рівні нулю.");
            }
            this.h = h;
            this.k = k;
            this.a = a;
            this.b = b;
        }

        // Обчислення значення функції для еліпса
        public override double Calculate(double x)
        {
            return k + b * Math.Sqrt(1 - Math.Pow((x - h) / a, 2));
        }
    }

    // Похідний клас Hyperbola 
    internal class Hyperbola : Function
    {
        public override double Calculate(double x)
        {
            if (x == 0)
                throw new ArgumentException("x не може бути рівний нулю.");
            return 1 / x;
        }
    }
}

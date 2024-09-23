using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a = double.Parse(Console.ReadLine());
                IFigureInfo f1 = new Circle(a);
                f1.Print("doira");

                f1 = new Triangle(3, 4, 5);
                f1.Print("To'g'ri burchakli Uchburchak");

                f1 = new Restangle(5, 6);
                f1.Print("to'g'ri to'rtburchak");
            }
            catch(FormatException)
            {
                Console.WriteLine("dastur tugadi");
            }

        }
    }
    interface IFigureInfo
    {
        /*public void practise()
        {
        Xatolik yuzaga keladi
        }
        public int h(int a)
        {
            return 0;
        }*/
        double Area();
        double Perimetr();
        
        void Print(string n);//interface ga xech qanday modificator ishlatilmaydi(ochiq)-Interface bizga qolib ketgan
        
    }
    class Circle:IFigureInfo
        {
        double r;
       public Circle(double R)
        {
            r = R;
        }
        public double Area()
        {
           
            return Math.PI*r*r;
        }
        public double Perimetr()
        {
            return 2*Math.PI*r;
        }
        public void Print(string n)
        {
            Console.WriteLine($"{n} ning yuzasi:{Area()} ,perimetri:{Perimetr()}");
        }
        }
    class Triangle:IFigureInfo
    {
        double a, b, c;
        public Triangle(double x,double y,double z)
        {
            a = x;b = y;c = z;
        }
        public double Area ()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
        public double Perimetr()
        {
            return a + b + c;
        }
        public void Print(string n)
        {
            Console.WriteLine($"{n}ning Yuzasi:{Area()},perimetri:{Perimetr()}");
        }
    }
    class Restangle:IFigureInfo
    {
        double w, h;
        public Restangle(double x,double y)
        {
            w = x;h = y;
        }
        public double Area()
        {
            return w * h;
        }
        public double Perimetr()
        {
            return 2 * (w + h);
        }
        public void Print(string n)
        {
            Console.WriteLine($"{n } ning yuzasi:{Area()},Perimetri:{Perimetr()}");
        }
    }
    interface Isecond
    {
        double Sum();
        double Max(double[,]a, double n, double m);
        double Min(double[,]a, double n, double m);
        double Average(double[,]a, double n, double m);//matritsa elementlari o'rtacha qiymati
        double Determinant(double[,]a, double n, double m);
        double Normal1(double[,]a, double n, double m);
        double Normal2(double[,]a, double n, double m);
        double Trace(double[,]a, double n, double m);
        void Print();
    }
    class Matrix2 : Isecond
    { 
        public double Sum(double [,]a,double n,double m)
        { double s = 0;
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    s += a[i, j];
                }
            }
            return s;
        }
        public Max(double)
    }
}

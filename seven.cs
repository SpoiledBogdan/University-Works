using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Parallelepiped
    {
        private double length;
        private double height;
        private double width;

        // Конструктор без параметров 
        public Parallelepiped()
        {
            try
            {
                Console.Write("Введите длину: ");
                length = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите высоту: ");
                height = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите ширину: ");
                width = Convert.ToDouble(Console.ReadLine());
            }

            catch
            {
                Console.WriteLine("Ошибка ввода данных");
            }
        }

        // Конструктор с параметрами
        public Parallelepiped(double length_, double height_, double width_)
        {
            length = length_;
            height = height_;
            width = width_;
        }

        // Метод расчета площади параллелепипеда
        public void square()
        {
            double sqr = 2 * (length * width + width * height + length * height);
            Console.WriteLine($"Площадь поверхности параллелепипеда равна {sqr}");

        }

        public void summmary()
        {
            double sum = 4 * (length + width + height);
            Console.WriteLine($"Сумма длин всех ребер параллелепипеда равна {sum}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создание объекта с конструктором без параметров:");
            Parallelepiped one = new Parallelepiped();
            one.square();
            one.summmary();

            Console.WriteLine("\nСоздание объекта с конструктором c параметрами:");
            Parallelepiped two = new Parallelepiped(6, 4, 5);
            two.square();
            two.summmary();

            Console.ReadKey();
        }
    }
}


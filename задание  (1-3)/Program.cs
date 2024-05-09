using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание___1_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //1 
            //Rectangle rec = new Rectangle(4, 2);
            //rec.ShowInfo();
            //Console.WriteLine($"периметр прямоугольника {rec.PerimeterCalculator()}");
            //Console.WriteLine($"Площадь прямоугольника { rec.AreaCalculator()}");
            //rec.AreaCalculator();


            //2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Title title = new Title("Скаазаки Пушкина");
            title.ShowInfo();
            Console.ForegroundColor = ConsoleColor.Blue;
            Autor author = new Autor("А.С.Пушкин");
            author.ShowInfo();
            Console.ForegroundColor = ConsoleColor.Green;
            Content content = new Content("Золотая рыбка ");
            content.ShowInfo();

            ///3
            
            
                Figure figure = new Figure(Point.Init(), Point.Init(), Point.Init());
                figure.PerimeterCalc();
                Console.ReadLine();





              
        }
    }
}

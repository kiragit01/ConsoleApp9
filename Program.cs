using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.CursorVisible = false;


                //Задача 1. Используя двузначное случайное число, вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции

                Random random = new Random();
                int num = random.Next(10, 99);
                string s = num % 2 == 0 ? "чётное" : "нечётное";
                Console.WriteLine(s);


                //Задача 2.Используя случайное число в диапазоне от 1 до 7, вывести на экран название дня недели.

                int day = random.Next(1, 7);

                switch (day)
                {
                    case 1: Console.WriteLine("Понедельник"); break;
                    case 2: Console.WriteLine("Вторник"); break;
                    case 3: Console.WriteLine("Среда"); break;
                    case 4: Console.WriteLine("Четверг"); break;
                    case 5: Console.WriteLine("Пятница"); break;
                    case 6: Console.WriteLine("Суббота"); break;
                    case 7: Console.WriteLine("Воскресенье"); break;
                }


                //Задача 3. Даны три целых положительных числа. Если все они четные, каждое число уменьшить в 2 раза, если хотя бы одно из них четное, увеличить каждое число в 2 раза, если четных чисел нет, каждое число увеличить на 1.

                //Console.Write("a = ");
                //int a = int.Parse(Console.ReadLine());
                //Console.Write("b = ");
                //int b = int.Parse(Console.ReadLine());
                //Console.Write("c = ");
                //int c = int.Parse(Console.ReadLine());
                //if (a % 2 == 0 && b % 2 == 0 && c % 2 == 0)
                //{
                //    a /= 2;
                //    b /= 2;
                //    c /= 2;
                //}
                //else if (a % 2 == 0 || b % 2 == 0 || c % 2 == 0)
                //{
                //    a *= 2;
                //    b *= 2;
                //    c *= 2;
                //}
                //else
                //{
                //    a++;
                //    b++;
                //    c++;
                //}
                //Console.WriteLine($"{a} \t{b} \t{c}");


                //Задача 4. Проведен тест, оцениваемый в целочисленных баллах от нуля до ста. Вывести на экран оценку тестируемого в зависимости от набранного количества баллов:
                //от 90 до 100 – «отлично», от 70 до 89 – «хорошо», от 50 до 69 – «удовлетворительно», менее 50 – «неудовлетворительно».

                //Console.Write("Введите ваш балл: ");
                int score = random.Next(100);
                if (90 <= score && score <= 100)
                    Console.WriteLine("отлично");
                else if (70 <= score && score <= 89)
                    Console.WriteLine("хорошо");
                else if (50 <= score && score <= 69)
                    Console.WriteLine("удовлетворительно");
                else
                    Console.WriteLine("неудовлетворительно");



                //Задача 5. Дан признак геометрической фигуры на плоскости: к – круг, п – прямоугольник, т - треугольник.
                //Вывести на экран периметр и площадь заданной фигуры (данные, необходимые для расчетов, запросить у пользователя).

                Console.WriteLine("Введите признак геометрической фигуры: ");
                char f = char.Parse(Console.ReadLine());
                double perimeter, square;
                int a, b, c, h;
                switch (f)
                {
                    case 'к': case 'К':
                        Console.Write("Введите радиус круга: ");
                        int r = int.Parse(Console.ReadLine());
                        perimeter = 2 * Math.PI * r;
                        square = Math.PI * Math.Pow(r, 2);
                        Console.WriteLine($"Периметр = {perimeter} \n Площадь = {square}");
                        break;

                    case 'п': case 'П':
                        Console.WriteLine("Введите стороны прямоугольника: ");
                        Console.Write("a = ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("b = ");
                        b = int.Parse(Console.ReadLine());
                        perimeter = (a + b) * 2;
                        square = a * b;
                        Console.WriteLine($"Периметр = {perimeter} \n Площадь = {square}");
                        break;

                    case 'т': case 'Т':
                        Console.WriteLine("Введите стороны треугольника: ");
                        Console.Write("a = ");
                        a = int.Parse(Console.ReadLine());
                        Console.Write("b = ");
                        b = int.Parse(Console.ReadLine());
                        Console.Write("c = ");
                        c = int.Parse(Console.ReadLine());
                        Console.Write("h(Высота) = ");
                        h = int.Parse(Console.ReadLine());
                        perimeter = a + b + c;
                        square = (a * h) / 2;
                        Console.WriteLine($"Периметр = {perimeter} \n Площадь = {square}");
                        break;

                    default:
                        Console.WriteLine("Введённая вами фигура отсутсвует в этой программе");
                        break;
                }


                //Задача 6.Написать приложение, которое позволяет вычислить сумму страхового взноса(SV) для автомобиля.
                //Входные данные будут вводиться с клавиатуры:
                Console.Write("марка автомобиля - ");
                string ma = Console.ReadLine();
                Console.Write("Срок страхования(от 1 до 12) - ");
                int month = int.Parse(Console.ReadLine());
                while (month <= 0 || month >= 12)
                {
                    Console.Write("Вы ввели неверное число месяцев. Введите заново: ");
                    month = int.Parse(Console.ReadLine());
                }

                double sum, kt = 0;

                if (month < 3)
                    kt = 10;
                else if (month >= 3 && month < 6)
                    kt = 8;
                else if (month >= 6 && month < 12)
                    kt = 5;

                sum = 50 * month * (1 + kt / 100);

                Console.WriteLine($"Ваш автомобиль марки {ma} был застрахован \nСумма страхового взноса составила {sum}.");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }

            Console.ReadKey();

        }
    }
}

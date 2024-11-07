using System;

namespace Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Лабораторная 1.
            Упражнение 2.1 Написать программу, которая спрашивает имя
            пользователя, и затем приветствует пользователя по имени.*/
            Console.WriteLine("Лабораторная 1");
            Console.WriteLine("Упражнение 2.1");
            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}");
            Console.ReadKey();

            //Упражнение 2.2
            Console.WriteLine("Упражнение 2.2");
            Console.WriteLine("Введите делимое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите делитель числа: ");
            int b = Convert.ToInt32(Console.ReadLine());

            try { int c = a / b;
                  Console.WriteLine($"Результат: {c}"); 
            }
            catch { Console.WriteLine("На ноль делить нельзя!"); }
            Console.ReadKey();

            //Домашнее задание 2.1 
            Console.WriteLine("Домашнее задание 2.1");
            char[] rus = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            Console.WriteLine("Введите букву русского алфавита (строчную):");
            char inp = char.Parse(Console.ReadLine());
            int idx = Array.IndexOf(rus, inp);
            int nexi = (idx + 1) % rus.Length;
            char nex = rus[nexi];
            Console.WriteLine($"Следующая буква: {nex}");
            Console.ReadKey();

            //Домашнее задание 2.2
            Console.WriteLine("Домашнее задание 2.1");
            Console.Write("Введите коэффициент a: ");
            double ak = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            double bk = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент c: ");
            double ck = double.Parse(Console.ReadLine());

            double dis = bk * bk - 4 * ak * ck;

            if (dis > 0)
            {
                double r1 = (-bk + Math.Sqrt(dis)) / (2 * ak);
                double r2 = (-bk - Math.Sqrt(dis)) / (2 * ak);
                Console.WriteLine($"Корни уравнения: x1 = {r1}, x2 = {r2}");
            }
            else if (dis == 0)
            {
                double rt = -bk / (2 * ak);
                Console.WriteLine($"Уравнение имеет один корень: x = {rt}");
            }
            else
            {
                Console.WriteLine("Уравнение не имеет действительных корней");
            }
            Console.ReadKey();



        }
    }
}

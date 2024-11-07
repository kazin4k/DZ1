using System;
using System.Globalization;
using System.Threading;

namespace Zadachi_iz_faila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Задание 1");
            double e = Math.Round(Math.E, 1);
            Console.WriteLine(e);
            Console.ReadKey();

            //Задание 2
            Console.WriteLine("Задание 2");
            Console.WriteLine("50");
            Console.WriteLine("10");
            Console.ReadKey();

            //Задание 3
            Console.WriteLine("Задание 3");
            Console.WriteLine("56");
            Console.WriteLine("45");
            Console.WriteLine("78");
            Console.WriteLine("42");
            Console.ReadKey();

            //Задание 4
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + 10);
            Console.ReadKey();

            //Задание 5
            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите сторону квадрата: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(b * 4);
            Console.ReadKey();

            //Задание 6
            Console.WriteLine("Задание 6");
            Console.WriteLine("Введите радиус окружности: ");
            int c = Convert.ToInt32(Console.ReadLine());
            var d = c * Math.PI * 2;
            var f = Math.PI * c * c;
            Console.WriteLine(d.ToString());
            Console.WriteLine(f.ToString());
            Console.ReadKey();

            //Задание 7
            Console.WriteLine("Задание 7");
            Console.WriteLine("Введите x: ");
            var y = Math.Cos(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(y.ToString());
            Console.ReadKey();

            //Задание 8
            Console.WriteLine("Задание 8");
            Console.WriteLine("Введите  основание трапеции: ");
            var g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите  основание трапеции: ");
            var i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту трапеции: ");
            var h = Convert.ToInt32(Console.ReadLine());
            var j = g + i + 2 * Math.Sqrt(h * h + (Math.Max(g, i) - Math.Min(i, g)) / 4);
            Console.WriteLine(j.ToString());
            Console.ReadKey();

            //Задание 9 
            Console.WriteLine("Задание 9");
            Console.WriteLine("Количество конфет: ");
            var k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество печенья: ");
            var l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество яблок: ");
            var q = Convert.ToInt32(Console.ReadLine());
            int m = 200;
            int o = 150;
            int p = 300;
            var ss = k * m + l * o + q * p;
            Console.WriteLine("Сумма покупки: ");
            Console.WriteLine(ss.ToString());
            Console.ReadKey();

            //Задание 10
            Console.WriteLine("Задание 10");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("     Труд");
            Console.WriteLine("           Май");
            Console.ReadKey();

            //Задание 11
            Console.WriteLine("Задание 11");
            try
            {
                Console.WriteLine("Введите 1 число: ");
                string t = Console.ReadLine();
                t = t.Replace(',', '.');
                double tt = double.Parse(t, CultureInfo.InvariantCulture);
                Console.WriteLine("Введите 2 число: ");
                string u = Console.ReadLine();
                u = u.Replace(",", ".");
                double uu = double.Parse(u, CultureInfo.InvariantCulture);

                double ttt = tt;
                tt = uu;
                uu = ttt;
                Console.WriteLine($"Результат: 1 число: {tt}, 2 число: {uu}");
            }
            catch
            {
                Console.WriteLine("Произошла ошибка");
            }
            Console.ReadKey();

            //Задание 12
            Console.WriteLine("Задание 12");
            Console.WriteLine("Выберите фигуру: круг  прямоугольник  треугольник");
            string aa = Console.ReadLine();
            if (aa == "круг")
            {
                Console.WriteLine("Введите радиус круга: ");
                double rr = double.Parse(Console.ReadLine());
                Console.WriteLine("Площадь или периметр");
                string kk = Console.ReadLine();
                if (kk == "площадь")
                {
                    Console.WriteLine(Math.PI * rr * rr);
                }
                if (kk == "периметр")
                {
                    Console.WriteLine(2 * Math.PI * rr);
                }
                Console.ReadKey();
            }
            if (aa == "прямоугольник")
            {
                Console.WriteLine("Задайте стороны:");
                double a1 = double.Parse(Console.ReadLine());
                double a2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Площадь или периметр");
                string zz = Console.ReadLine();
                if (zz == "площадь")
                {
                    Console.WriteLine(a1 * a2);
                }
                if (zz == "периметр")
                {
                    Console.WriteLine(2 * (a1 + a2));
                }
                Console.ReadKey();
            }
            if (aa == "треугольник")
            {
                Console.WriteLine("Задайте стороны:");
                double b1 = double.Parse(Console.ReadLine());
                double b2 = double.Parse(Console.ReadLine());
                double b3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Площадь или периметр");
                string zz = Console.ReadLine();
                if (zz == "площадь")
                {
                    double pp = b1 + b2 + b3;
                    Console.WriteLine(Math.Sqrt(pp * (pp - b1) * (pp - b2) * (pp - b3)));
                }
                if (zz == "периметр")
                {
                    Console.WriteLine(b1 + b2 + b3);
                }
                Console.ReadKey();
            }
            //Задание 13
            Console.WriteLine("Задание 13");
            Console.WriteLine("Введите число:");
            double aaa = double.Parse(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {aaa}");
            Console.ReadKey();

            //Задание 14
            Console.WriteLine("Задание 14");
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");

            //Задание 15
            Console.WriteLine("Задание 15");
            Random random = new Random();
            for (int ii = 0; ii < 4; ii++)
            {
                Console.WriteLine(random.NextDouble());
            }
            Console.ReadKey();

            //Задание 16
            Console.WriteLine("Задание 16");
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

            //Задание 17
            Console.WriteLine("Задание 17");
            Console.WriteLine("Введите 1 целое число: ");
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2 целое число: ");
            int s2 = int.Parse(Console.ReadLine());
            double ar = (s1 + s2) / 2;
            double geo = Math.Sqrt(s1*s2);
            Console.WriteLine($"Среднее арифметическое: {ar}, среднее геометрическое: {geo}");
            Console.ReadKey();

            //Задание 18
            Console.WriteLine("Задание 18");
            Console.WriteLine("Введите координаты 2 точек (сначала x,потом y в столбик)");
            int x1=int.Parse(Console.ReadLine());
            int y1=int.Parse(Console.ReadLine());
            int x2=int.Parse(Console.ReadLine());
            int y2=int.Parse(Console.ReadLine());
            Console.WriteLine("Расстояние между 2 точками:");
            Console.WriteLine(Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)));

            //Задание 19
            Console.WriteLine("Задание 19");
            Console.WriteLine("Введите значения переменных a, b, c:");
            var aa1 = double.Parse(Console.ReadLine());
            var bb1 = double.Parse(Console.ReadLine());
            var cc1 = double.Parse(Console.ReadLine());
            // a)
            var bbb1 = bb1;
            var ccc1 = cc1;
            var aaa1 = aa1;
            var nn = bbb1;
            bbb1 = ccc1;
            var nn1 = aaa1;
            aaa1 = nn;
            ccc1 = nn1;
            Console.WriteLine($"a) a = {aaa1} b = {bbb1} c = {ccc1}");
            // b)
            nn = bb1;
            bb1 = aa1;
            nn1 = cc1;
            cc1 = nn;
            aa1 = nn1;
            Console.WriteLine($"b) a = {aa1} b = {bb1} c = {cc1}");
            Console.ReadKey();

            //Задание 20
            Console.WriteLine("Задание 20");
            Console.WriteLine("Введите количество секунд:");
            int z = int.Parse(Console.ReadLine());
            int hour = z / 3600;
            int min = (z % 3600) / 60;
            int sec = z % 60;
            Console.WriteLine($"Количество полных часов: {hour}, минут: {min}, секунд: {sec}");
            Console.ReadKey();

            //Задание 21
            Console.WriteLine("Задание 21");
            int v = (543 / 130) * (130 / 130);
            Console.WriteLine(v);
            Console.ReadKey();

            //Задание 22
            Console.WriteLine("Задание 22");
            Console.WriteLine("Введите трехзначное число:");
            int ch = int.Parse(Console.ReadLine());
            int ch1 = (ch % 10)*100+(((ch/10)%10)*10)+(ch / 100);
            Console.WriteLine(ch1);
            Console.ReadKey();

            //Задание 23
            Console.WriteLine("Задание 23");
            Console.WriteLine("Введите число (n > 999):");
            int sot = int.Parse(Console.ReadLine());
            int sot1 = (sot % 1000) / 100;
            Console.WriteLine($"Число сотен: {sot1}");
            int sot2 = (sot % 10000) / 1000;
            Console.WriteLine($"Число тысяч: {sot2}");
            Console.ReadKey();

            //Задание 24
            Console.WriteLine("Задание 24");
            Console.WriteLine("Введите четырехзначное число:");
            int so = int.Parse(Console.ReadLine());
            int so1 = so % 10;
            int so2 = (so / 10)%10;
            int so3 = (so / 100)%10;
            int so4 = so / 1000;
            // a)
            int soo1 = so1 * 1000 + so2 * 100 + so3 * 10 + so4;
            // b)
            int soo2 = so2 * 1000 + so1 * 100 + so4 * 10 + so3;
            // c)
            int soo3 = so1 * 1000 + so3 * 100 + so2 * 10 + so4;
            // d)
            int soo4 = so3 * 1000 + so4 * 100 + so1 * 10 + so2;
            Console.WriteLine($"a) {soo1}, b) {soo2}, c) {soo3}, d) {soo4}");
            Console.ReadKey();

            //Задание 25
            Console.WriteLine("Задание 25");
            Console.WriteLine("Введите значение n:");
            int nnn = int.Parse(Console.ReadLine());
            for (int aaaa = 1; aaaa <= 9; aaaa++)
            {
                for (int bbbb = 0; bbbb <= 9; bbbb++)
                {
                    for (int cccc = 0; cccc <= 9; cccc++)
                    {
                        int xxxx = 100 * aaaa + 10 * bbbb + cccc;
                        if (10 * aaaa + bbbb + cccc == nnn)
                        {
                            Console.WriteLine($"Найдено x: {xxxx}");
                        }
                    }
                }
            }
            Console.ReadKey();

            //Задание 26
            Console.WriteLine("Задание 26");
            Console.WriteLine("Количество часов:");
            int hr = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество минут:");
            int mn = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество секунд:");
            int sc = int.Parse(Console.ReadLine());
            double grad = ((hr * 3600 + mn * 60 + sc) * 0.1) % 360;
            Console.WriteLine($"Количество градусов: {grad}");

            //Задание 27
            Console.WriteLine("Задание 27");
            Console.WriteLine("Введите угол y (в радианах):");
            double y11 = double.Parse(Console.ReadLine());
            double deg = y11 * (180 / Math.PI);
            int ho = (int)(deg / 30);
            double rem = deg - (ho * 30);
            int mi = (int)(rem / 6);
            double minu = mi * 6;
            Console.WriteLine($"Полные часы: {ho}");
            Console.WriteLine($"Полные минуты: {mi}");
            Console.WriteLine($"Угол минутной стрелки: {minu}°");
            Console.ReadKey();
        
    

            //Задание 28
            Console.WriteLine("Задание 28");
            Console.WriteLine("Введите первое число:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            double num3 = double.Parse(Console.ReadLine());

            double abs1 = Math.Abs(num1);
            double abs2 = Math.Abs(num2);
            double abs3 = Math.Abs(num3);

            double minAbs = Math.Min(Math.Min(abs1, abs2), abs3);

            Console.WriteLine($"Меньшее по модулю число: {minAbs}");
            Console.ReadLine();

            //Задание 29
            Console.WriteLine("Задание 29");
            Console.WriteLine("Введите первое число:");
            double nu1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double nu2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            double nu3 = double.Parse(Console.ReadLine());

            double maxNum = Math.Max(nu1, Math.Max(nu2, nu3));
            double minNum = Math.Min(nu1, Math.Min(nu2, nu3));

            double sum = maxNum + minNum;

            Console.WriteLine($"Сумма большего и меньшего чисел: {sum}");
            Console.ReadKey();

            //Задание 30
            Console.WriteLine("Задание 30");
            Console.WriteLine("Введите натуральное число:");
            int ni = int.Parse(Console.ReadLine());
            int count = 0;
            for (int ii = 1; ii <= Math.Sqrt(ni); ii++)
            {
                if (ni % ii == 0)
                {
                    count++;
                    if (i != ni / ii)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Общее количество делителей: {count}");
            Console.ReadKey();

            //Задание 31
            Console.WriteLine("Задание 31");
            Console.WriteLine("Введите коэффициенты A, B, C, D (в столбик):");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            bool found = false;
            for (int x = -100; x <= 100; x++)
            {
                double result = A * Math.Pow(x, 3) + B * Math.Pow(x, 2) + C * x + D;
                if (result == 0)
                {
                    Console.WriteLine($"{x} является корнем уравнения");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Корней нет");
            }
            Console.ReadKey();

            //Задание 32
            Console.WriteLine("Задание 32");
            Console.WriteLine("Введите первый элемент арифметической прогрессии:");
            double ae1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй элемент арифметической прогрессии:");
            double ae2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер элемента:");
            int n = int.Parse(Console.ReadLine());
            double dd = ae2 - ae1;
            double an = ae1 + (n - 1) * dd;
            Console.WriteLine($"Элемент арифметической прогрессии: {an}");
            Console.ReadKey ();

            //Задание 33
            Console.WriteLine("Задание 33");
            Console.WriteLine("Вы пенсионер?");
            string pen = Console.ReadLine();
            Console.WriteLine("Вы студент?");
            string stud = Console.ReadLine();
            bool nax = false;
            if (pen == stud) {
                Console.WriteLine("Вы не можете получить кредит");
                nax = true;
            }
            if (nax == false)
            {
                Console.WriteLine("Вы трудоустроены?");
                string trud = Console.ReadLine();
                if ((trud == stud) || (trud == pen))
                {
                    Console.WriteLine("Вы не можете получить кредит");
                }
                if ((trud != stud) || (trud != pen))
                {
                    Console.WriteLine("Вы можете получить кредит");
                }
            }
            Console.ReadKey();

            //Задание 34
            Console.WriteLine("Задание 34");
            Console.WriteLine("Введите свое имя:");
            string name = Console.ReadLine();
            // a)
            Console.WriteLine(name);
            // b)
            Console.WriteLine($"Привет {name}");
            Console.ReadKey();

            //Задание 35
            Console.WriteLine("Задание 35");
            string privet = Console.ReadLine();
            Console.Write("Как вас зовут? ");
            string Garik = Console.ReadLine();
            Console.WriteLine($"Привет, {Garik}.");
            string cheznaesh = Console.ReadLine();
            Console.WriteLine("Да");
            string govorii = Console.ReadLine();
            Console.WriteLine("Нет");
            Thread.Sleep(5000);
            Console.WriteLine("Но могу показать");
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ReadKey();
            Console.ResetColor();

            //Задание 36
            Console.WriteLine("Задание 36");
            Console.WriteLine("Введите способ:");
            Console.WriteLine("1. Генерация рандомных 12 чисел");
            Console.WriteLine("2. Введение 12 чисел вручную");
            Console.WriteLine("(Введите 1 или 2)");
            Random random1 = new Random();
            int sposob = int.Parse(Console.ReadLine());
            if (sposob == 2)
            {
                string ean = Console.ReadLine();
                int summa = 0;
                for (i = 0; i < 12; i++)
                {
                    int eanint = int.Parse(ean[i].ToString());
                    if (i % 2 == 0)
                    {
                        summa += eanint;
                    }
                    else
                    {
                        summa += eanint * 3;
                    }
                }
                summa = summa % 10;
                if (summa == 0)
                {
                    Console.WriteLine($"{ean}0");
                }
                else
                {
                    int t1 = 10 - summa;
                    Console.WriteLine($"{ean}{t1}");
                }
            }
            if (sposob == 1)
            {
                string ean = "";
                int summa = 0;
                for (i = 0; i < 12; i++)
                {
                    ean += random1.Next(0, 10).ToString();
                }
                Console.WriteLine($"Сгенерированные числа: {ean}");

                for (i = 0; i < 12; i++)
                {
                    int eanint = int.Parse(ean[i].ToString());
                    if (i % 2 == 0)
                    {
                        summa += eanint;
                    }
                    else
                    {
                        summa += eanint * 3;
                    }
                }
                summa = summa % 10;
                if (summa == 0)
                {
                    Console.WriteLine($"{ean}0");
                }
                else
                {
                    int t1 = 10 - summa;
                    Console.WriteLine($"{ean}{t1}");
                }
            }
            Console.ReadLine();




            
        }
    }
}

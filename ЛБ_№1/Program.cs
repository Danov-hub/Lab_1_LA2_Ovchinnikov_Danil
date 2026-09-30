using System;

class Program
{
    static void Main()
    {
        Methods p = new Methods();

        //1.1
        Console.WriteLine("Задание 1.1");
        Console.Write("Введите число: ");
        double d;
        if (!double.TryParse(Console.ReadLine(), out d))
        {
            Console.WriteLine("Ошибка ввода");
        }
        else
        {
            Console.WriteLine("Результат: " + p.fraction(d));
        }
        Console.WriteLine();

        //1.3
        Console.WriteLine("Задание 1.3");
        Console.WriteLine("Введите цифру (0-9): ");
        string s = Console.ReadLine();
        if (s.Length != 1 || s[0] < '0' || s[0] > '9')
        {
            Console.WriteLine("Ошибка, введите одну цифру");
        }
        else
        {
            Console.WriteLine("Результат: " + p.charToNum(s[0]));
        }
        Console.WriteLine();

        //1.5
        Console.WriteLine("Задание 1.5");
        Console.Write("Введите число: ");
        int n1;
        if (!int.TryParse(Console.ReadLine(), out n1))
        {
            Console.WriteLine("Ошибка ввода");
        }
        else
        {
            Console.WriteLine("Результат: " + p.is2Digits(n1));
        }
        Console.WriteLine();

        //1.7
        Console.WriteLine("Задание 1.7");
        int a, b, num;
        Console.Write("Введите a: ");
        int.TryParse(Console.ReadLine(), out a);
        Console.Write("Введите b: ");
        int.TryParse(Console.ReadLine(), out b);
        Console.Write("Введите num: ");
        int.TryParse(Console.ReadLine(), out num);
        Console.WriteLine("Результат: " + p.isInRange(a, b, num));
        Console.WriteLine();

        //1.9
        Console.WriteLine("Задание 1.9");
        int e1, e2, e3;
        Console.Write("Введите a: ");
        int.TryParse(Console.ReadLine(), out e1);
        Console.Write("Введите b: ");
        int.TryParse(Console.ReadLine(), out e2);
        Console.Write("Введите c: ");
        int.TryParse(Console.ReadLine(), out e3);
        Console.WriteLine("Результат: " + p.isEqual(e1, e2, e3));
        Console.WriteLine();

        //2.1
        Console.WriteLine("Задание 2.1");
        Console.Write("Введите число: ");
        int m;
        if (!int.TryParse(Console.ReadLine(), out m))
        {
            Console.WriteLine("Ошибка ввода");
        }
        else
        {
            Console.WriteLine("Результат: " + p.abs(m));
        }
        Console.WriteLine();

        //2.3
        Console.WriteLine("Задание 2.3");
        Console.Write("Введите число: ");
        int t;
        if (!int.TryParse(Console.ReadLine(), out t))
        {
            Console.WriteLine("Ошибка ввода");
        }
        else
        {
            Console.WriteLine("Результат: " + p.is35(t));
        }
        Console.WriteLine();

        //2.5
        Console.WriteLine("Задание 2.5");
        int x1, y1, z1;
        Console.Write("Введите x: ");
        int.TryParse(Console.ReadLine(), out x1);
        Console.Write("Введите y: ");
        int.TryParse(Console.ReadLine(), out y1);
        Console.Write("Введите z: ");
        int.TryParse(Console.ReadLine(), out z1);
        Console.WriteLine("Результат: " + p.max3(x1, y1, z1));
        Console.WriteLine();

        //2.7
        Console.WriteLine("Задание 2.7");
        int s1, s2;
        Console.Write("Введите x: ");
        int.TryParse(Console.ReadLine(), out s1);
        Console.Write("Введите y: ");
        int.TryParse(Console.ReadLine(), out s2);
        Console.WriteLine("Результат: " + p.sum2(s1, s2));
        Console.WriteLine();

        //2.9
        Console.WriteLine("Задание 2.9");
        Console.Write("Введите номер дня (1-7): ");
        int dayNum;
        if (!int.TryParse(Console.ReadLine(), out dayNum))
        {
            Console.WriteLine("Ошибка ввода");
        }
        else
        {
            Console.WriteLine("Результат: " + p.day(dayNum));
        }
        Console.WriteLine();

        //3.1
        Console.WriteLine("Задание 3.1");
        Console.Write("Введите x: ");
        int c1;
        if (!int.TryParse(Console.ReadLine(), out c1))
        {
            Console.WriteLine("Ошибка ввода");
        }
        else
        {
            Console.WriteLine("Результат: " + p.listNums(c1));
        }
        Console.WriteLine();

        //3.3
        Console.WriteLine("Задание 3.3");
        Console.Write("Введите x: ");
        int c3;
        if (!int.TryParse(Console.ReadLine(), out c3))
        {
            Console.WriteLine("Ошибка ввода");
        }
        else
        {
            Console.WriteLine("Результат: " + p.chet(c3));
        }
        Console.WriteLine();

        //3.5
        Console.WriteLine("Задание 3.5");
        Console.Write("Введите число: ");
        long c5;
        if (!long.TryParse(Console.ReadLine(), out c5))
        {
            Console.WriteLine("Ошибка ввода");
        }
        else
        {
            Console.WriteLine("Результат: " + p.numLen(c5));
        }
        Console.WriteLine();

        //3.7
        Console.WriteLine("Задание 3.7");
        Console.Write("Введите x: ");
        int c7;
        if (!int.TryParse(Console.ReadLine(), out c7))
        {
            Console.WriteLine("Ошибка ввода");
        }
        else
        {
            Console.WriteLine("Результат: ");
            p.square(c7);
        }
        Console.WriteLine();

        //3.9
        Console.WriteLine("Задание 3.9");
        Console.Write("Введите x: ");
        int c9;
        if (!int.TryParse(Console.ReadLine(), out c9))
        {
            Console.WriteLine("Ошибка ввода");
        }
        else
        {
            Console.WriteLine("Результат:");
            p.rightTriangle(c9);
        }
        Console.WriteLine();

        //4.1
        Console.WriteLine("Задание 4.1");
        int[] arr1 = { 1, 2, 3, 4, 2, 2, 5 };
        Console.WriteLine("Массив: 1 2 3 4 2 2 5");
        Console.Write("Введите x: ");
        int f1;
        if (!int.TryParse(Console.ReadLine(), out f1))
        {
            Console.WriteLine("Ошибка ввода");
        }
        else
        {
            Console.WriteLine("Результат: " + p.findFirst(arr1, f1));
        }
        Console.WriteLine();

        //4.3
        Console.WriteLine("Задание 4.3");
        int[] arr3 = { 1, -2, -7, 4, 2, 2, 5 };
        Console.WriteLine("Массив: 1 -2 -7 4 2 2 5");
        Console.WriteLine("Результат: " + p.maxAbs(arr3));
        Console.WriteLine();

        //4.5
        Console.WriteLine("Задание 4.5");
        int[] arr5 = { 1, 2, 3, 4, 5 };
        int[] ins5 = { 7, 8, 9 };
        int pos5 = 3;
        Console.WriteLine("arr: 1 2 3 4 5");
        Console.WriteLine("ins: 7 8 9");
        Console.WriteLine("pos: 3");
        int[] res5 = p.add(arr5, ins5, pos5);
        Console.Write("Результат: ");
        for (int i = 0; i < res5.Length; i++)
        {
            Console.Write(res5[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();

        //4.7
        Console.WriteLine("Задание 4.7");
        int[] arr7 = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Массив: 1 2 3 4 5");
        int[] res7 = p.reverseBack(arr7);
        Console.Write("Результат: ");
        for (int i = 0; i < res7.Length; i++)
        {
            Console.Write(res7[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();

        //4.9
        Console.WriteLine("Задание 4.9");
        int[] arr9 = { 1, 2, 3, 8, 2, 2, 9 };
        Console.WriteLine("Массив: 1 2 3 8 2 2 9");
        Console.Write("Введите x: ");
        int f9;
        if (!int.TryParse(Console.ReadLine(), out f9))
        {
            Console.WriteLine("Ошибка ввода");
        }
        else
        {
            int[] res9 = p.findAll(arr9, f9);
            Console.Write("Результат: [");
            for (int i = 0; i < res9.Length; i++)
            {
                Console.Write(res9[i]);
                if (i < res9.Length - 1) Console.Write(", ");
            }
            Console.WriteLine("]");
        }
        Console.WriteLine();
    }
}
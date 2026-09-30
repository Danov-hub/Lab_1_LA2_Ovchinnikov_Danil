using System;

class Methods
{
    //1.1
    public double fraction(double x)
    {
        int wholePart = (int)x;
        return x - wholePart;
    }

    //1.3
    public int charToNum(char x)
    {
        return x - '0';
    }

    //1.5
    public bool is2Digits(int x)
    {
        if (x < 0) x = -x;
        return x >= 10 && x <= 99;
    }

    //1.7
    public bool isInRange(int a, int b, int num)
    {
        int min, max;
        if (a < b)
        {
            min = a;
            max = b;
        }
        else
        {
            min = b;
            max = a;
        }
        return num >= min && num <= max;
    }

    //1.9
    public bool isEqual(int a, int b, int c)
    {
        return a == b && b == c;
    }

    //2.1
    public int abs(int x)
    {
        if (x < 0)
        {
            return -x;
        }
        else
        {
            return x;
        }
    }

    //2.3
    public bool is35(int x)
    {
        bool del3 = (x % 3 == 0);
        bool del5 = (x % 5 == 0);

        if (del3 && del5)
        {
            return false;
        }
        if (del3 || del5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //2.5
    public int max3(int x, int y, int z)
    {
        int max = x;
        if (y > max)
        {
            max = y;
        }
        if (z > max)
        {
            max = z;
        }
        return max;
    }

    //2.7
    public int sum2(int x, int y)
    {
        int sum = x + y;
        if (sum >= 10 && sum <= 19)
        {
            return 20;
        }
        else
        {
            return sum;
        }
    }

    //2.9
    public String day(int x)
    {
        switch (x)
        {
            case 1: return "понедельник";
            case 2: return "вторник";
            case 3: return "среда";
            case 4: return "четверг";
            case 5: return "пятница";
            case 6: return "суббота";
            case 7: return "воскресенье";
            default: return "это не день недели";
        }
    }

    //3.1
    public String listNums(int x)
    {
        String result = "";
        for (int i = 0; i <= x; i++)
        {
            result = result + i;
            if (i < x)
            {
                result = result + " ";
            }
        }
        return result;
    }

    //3.3
    public String chet(int x)
    {
        String result = "";
        for (int i = 0; i <= x; i = i + 2)
        {
            result = result + i;
            if (i + 2 <= x)
            {
                result = result + " ";
            }
        }
        return result;
    }

    //3.5
    public int numLen(long x)
    {
        if (x == 0)
        {
            return 1;
        }
        if (x < 0)
        {
            x = -x;
        }
        int count = 0;
        while (x > 0)
        {
            x = x / 10;
            count = count + 1;
        }
        return count;
    }

    //3.7
    public void square(int x)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    //3.9
    public void rightTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            for (int j = 0; j < x - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }


    //4.1
    public int findFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1;
    }

    //4.3
    public int maxAbs(int[] arr)
    {
        int best = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (abs(arr[i]) > abs(best))
            {
                best = arr[i];
            }
        }
        return best;
    }

    //4.5
    public int[] add(int[] arr, int[] ins, int pos)
    {
        int[] result = new int[arr.Length + ins.Length];
        for (int i = 0; i < pos; i++)
        {
            result[i] = arr[i];
        }

        for (int i = 0; i < ins.Length; i++)
        {
            result[pos + i] = ins[i];
        }

        for (int i = pos; i < arr.Length; i++)
        {
            result[i + ins.Length] = arr[i];
        }
        return result;
    }

    //4.7
    public int[] reverseBack(int[] arr)
    {
        int[] result = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[arr.Length - 1 - i];
        }
        return result;
    }

    //4.9
    public int[] findAll(int[] arr, int x)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x) count++;
        }

        int[] result = new int[count];
        int k = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                result[k] = i;
                k++;
            }
        }
        return result;
    }
}
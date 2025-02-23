
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

internal class Program
{
   
    class People()
    {
       
        public double height;
        public double age;
        public string name;

        public void dialog()
        {
            Console.WriteLine($"Меня зовут: {name}");
        }


          
    }

    
    
    private static void Main(string[] args)
    {
        void Nazvania()
        {
            // Типы данных в C#

            string variable_string = "эта строка";
            int variable_int = 12;
            double variable_double = 24.5;
            bool variable_bool = true;
            char variable_char = 'a';

            Console.WriteLine("тип данных - строчка " + variable_string);
            Console.WriteLine("тип данных - целочисленный " + variable_int);
            Console.WriteLine("тип данных - дробный " + variable_double);
            Console.WriteLine("тип данных - логический " + variable_bool);
            Console.WriteLine("тип данных - символьный " + variable_char);
            Console.WriteLine(variable_int + variable_double);

            // Сложение двух переменных в консоли для вывода

            Console.WriteLine("ввидите переменную типа int: ");
            int xInt;
            xInt = int.Parse(Console.ReadLine());
            Console.WriteLine(xInt + " - ваше значение. ");


            Console.WriteLine("ввидите переменную типа double: ");
            double xDouble;
            xDouble = double.Parse(Console.ReadLine());
            Console.WriteLine(xDouble + " - ваше значение. ");

            Console.WriteLine("ввидите переменную типа bool: ");
            bool xBool;
            xBool = bool.Parse(Console.ReadLine());
            Console.WriteLine(xBool + " - ваше значение. ");

            Console.WriteLine("ввидите переменную типа char: ");
            char xChar;
            xChar = char.Parse(Console.ReadLine());
            Console.WriteLine(xChar + " - ваше значение. ");





            // 1 2 3 4 5 бла бла бла очень важно

        }
        void condition()
        {
            Console.WriteLine("Ввидите свой баланс:");
            int amountOfMoney = int.Parse(Console.ReadLine());

            if (amountOfMoney >= 2000)
            {
                Console.WriteLine("Я богат.");
            }
            else if (amountOfMoney > 0)
            {
                Console.WriteLine("Деньги есть, куплю у Владлена 500К");
            }
            else if (amountOfMoney < 0)
            {
                Console.WriteLine("Я должен, завтра придут коллекторы!");
            }
            else
            {
                Console.WriteLine("Денег нет");
            }
        }
        void cycle()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            i = 0;
            do
            {
                i++;
                Console.WriteLine(i);
            }
            while (i < 0);
            for (i = 0; i < 52; i++)
            {
                Console.WriteLine(i);
            }

            int mnojitel = 5;
            for (i = 0; i < 11; i++) ;
            {

                Console.WriteLine(mnojitel + "*" + i + " = " + i * mnojitel);
            }

            int[] numbers;
            int[] numbers_1 = new int[10];
            int[] numbers_2 = new int[5] { 1, 5, -23, -4, 52 };
            int[] numbers_3 = { 1, 24, 3, -8 };
            //оприделение масива

            int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine(matrix);
            foreach (int a in numbers_2)
            {
                Console.WriteLine(a);
            }

            for (int b = 0; b < numbers_2.Length; b++)
            {
                Console.WriteLine(b);
                Console.WriteLine(numbers_2[b]);

                Console.WriteLine("В ячейке под номером " + b + " хранится значение" + numbers_2[b]);
            }
        }
       
        int GetSquare(int x, int y)
        {
            return x * y;
        }
        double getKVADRAT(double x)
        {
        double result = x * x;
            return result;
        }
       

        var max = Int32.MaxValue;
        var min = Int32.MinValue;
    
        
           

       long factorial = Factorial(10);


       static long Factorial(int n)
            {
                if (n < 0)
                {
                    throw new ArgumentException("Факториал не определен для отрицательных чисел.");
                }
                if (n == 0 || n == 1)
                {
                    return 1;
                }
                long result = 1;
                for (int i = 2; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }





        People Yan = new People();
        Yan.age = 52;
        Yan.height = 199;
    }

}
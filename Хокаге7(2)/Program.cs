using System;


internal class Program
{
    private static void Main(string[] args)
    {
        void DataType()
        {


            // Типы данных в C#

            string variable_string = "Это строка";
            int variable_int = 12;
            double variable_double = 24.5;
            bool variable_bool = true;
            char variable_char = 'a';

            // Консольный вывод

            Console.WriteLine("Тип данных - строчка " + variable_string);
            Console.WriteLine("Тип данных - целочисленные " + variable_int);
            Console.WriteLine("Тип данных - дробный " + variable_double);
            Console.WriteLine("Тип данных - логические " + variable_bool);
            Console.WriteLine("Тип данных - символьные " + variable_char);

            // Сложение двух переменных в консоли для вывода 

            Console.WriteLine(variable_int + variable_double);

            // Консольный ввод и конвертация для него типов данных

            Console.WriteLine("Введите переменную типа int: ");
            int xInt;
            xInt = int.Parse(Console.ReadLine());
            Console.WriteLine(xInt + " - ваше значение.");

            Console.WriteLine("Введите переменную типа string: ");
            string xString;
            xString = Console.ReadLine();
            Console.WriteLine(xString + " - ваше значение.");

            Console.WriteLine("Введите переменную типа double: ");
            double xDouble;
            xDouble = double.Parse(Console.ReadLine());
            Console.WriteLine(xDouble + " - ваше значение.");

            Console.WriteLine("Введите переменную типа bool: ");
            bool xBool;
            xBool = bool.Parse(Console.ReadLine());
            Console.WriteLine(xBool + " - ваше значение.");

            Console.WriteLine("Введите переменную типа char: ");
            char xChar;
            xChar = char.Parse(Console.ReadLine());
            Console.WriteLine(xChar + " - ваше значение.");


            // Это нужное изменение
        }

        void Condition()
        {
            while (true)
            {
                Console.WriteLine("Введите свой баланс: ");

                int amountOfMoney = int.Parse(Console.ReadLine());

                if (amountOfMoney >= 200)
                {
                    Console.WriteLine("Я богат, куплю два доширака вместо одного");
                }
                else if (amountOfMoney > 0)
                {
                    Console.WriteLine("Деньги есть, но не хватает, пройди мимо магазина");
                }
                else if (amountOfMoney < 0)
                {
                    Console.WriteLine("Деньги задолжал сбер банку");
                }
                else
                {
                    Console.WriteLine("Денег нет, продам Серёжу за доширак");
                }
            }



        }

        void Cycle()
        {
            int i = 0;

            // Цикл с предусловием

            while (i < 10)
            {
                Console.WriteLine("Счёт итерации цикла while " + i);
                i++;
            }

            // Цикл с постусловием 
            i = 0;
            do
            {

                Console.WriteLine("Счёт итерации цикла do-while " + i);
                i++;
            } while (i == 2);

            int multiplier = 3;
            for (int j = 1; j <= 15; j++)
            {
                Console.WriteLine(multiplier + " * " + j + " = " + multiplier * j);

            }

            // определение массивов
            int[] array;
            int[] array2 = new int[10];
            int[] array3 = new int[5] { 1, 2, 3, 4, 5 };
            int[] array4 = { 1, 34, 23, -2, 12 };

            // определение многомерного массива

            int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine(matrix);




            // перебор индексов в массиве

            for (int e = 0; e < 10; e++)
            {
                Console.WriteLine(array2[e]);
                array2[e] = e + 1;
                Console.WriteLine(array2[e]);
            }

            //цикл для переборов значений в массиве

            foreach (int c in array2)
            {
                Console.WriteLine(c);
            }

        }


        int getSquare(int x, int y)
        { 
            return x * y; 
        }

      double getKVADRAT(double x)
        {
            var result = x * x;
            return result;
        }

        Console.WriteLine(getKVADRAT(100346));

        var max = Int32.MaxValue;
        var min = Int32.MinValue;

        Console.WriteLine(max + " " + min);

    }

    int getFactorial(int i)
    {
        int result = i!;

        return result;
    }



}
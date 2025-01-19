using System;

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
xInt = Int32.Parse(Console.ReadLine());
Console.WriteLine(xInt + " - ваше значение.");

Console.WriteLine("Введите переменную типа string: ");
string xString;
xString = Console.ReadLine();
Console.WriteLine(xString + " - ваше значение.");

Console.WriteLine("Введите переменную типа double: ");
double xDouble;
xDouble = Double.Parse(Console.ReadLine());
Console.WriteLine(xDouble + " - ваше значение.");

Console.WriteLine("Введите переменную типа bool: ");
bool xBool;
xBool = Boolean.Parse(Console.ReadLine());
Console.WriteLine(xBool + " - ваше значение.");

Console.WriteLine("Введите переменную типа char: ");
char xChar;
xChar = Char.Parse(Console.ReadLine());
Console.WriteLine(xChar + " - ваше значение.");


// Это нужное изменение


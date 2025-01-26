
using System.ComponentModel.Design;

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
    xInt = Int32.Parse(Console.ReadLine());
    Console.WriteLine(xInt + " - ваше значение. ");


    Console.WriteLine("ввидите переменную типа double: ");
    double xDouble;
    xDouble = Double.Parse(Console.ReadLine());
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

while (true)
{
    Console.WriteLine("Ввидите свой баланс:");
    int amountOfMoney = Int32.Parse(Console.ReadLine());

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
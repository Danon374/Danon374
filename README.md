using System;
string std;

while (true)
{
   Console.WriteLine("Выберите действие \n" +
  "1. Сложить 2 числа\n" +
  "2. Вычесть первое из второго\n" +
  "3. Перемножить два числа\n" +
  "4. Разделить первое на второе\n" +
  "5. Возвести в степень N первое число\n" +
  "6. Найти квадратный корень из числа\n" +
  "7. Найти 1 процент от числа\n" +
  "8. Найти факториал из числа\n" +
  "9. Выйти из программы");
 string stdo = Console.ReadLine();
int action = Convert.ToInt32(stdo);
double answer;
 if (action == 1)
 {
  Console.WriteLine("Введите первое число");
  string num1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
  string num2 = Console.ReadLine();
double intnum1 = Convert.ToDouble(num1);
double intnum2 = Convert.ToDouble(num2);
answer = intnum1 + intnum2;
  Console.WriteLine("Ответ:");
  Console.WriteLine(answer);
 }
 if (action == 2)
{
    Console.WriteLine("Введите первое число");
    string num1 = Console.ReadLine();
    Console.WriteLine("Введите второе число");
    string num2 = Console.ReadLine();
    double intnum1 = Convert.ToDouble(num1);
    double intnum2 = Convert.ToDouble(num2);
    answer = intnum1 - intnum2;
    Console.WriteLine("Ответ:");
    Console.WriteLine(answer);
}
if (action == 3)
{
    Console.WriteLine("Введите первое число");
    string num1 = Console.ReadLine();
    Console.WriteLine("Введите второе число");
    string num2 = Console.ReadLine();
    double intnum1 = Convert.ToDouble(num1);
    double intnum2 = Convert.ToDouble(num2);
    answer = intnum1 * intnum2;
    Console.WriteLine("Ответ:");
    Console.WriteLine(answer);
    break;
}
if (action == 4)
{
    Console.WriteLine("Введите первое число");
    string num1 = Console.ReadLine();
    Console.WriteLine("Введите второе число");
    string num2 = Console.ReadLine();
    double intnum1 = Convert.ToDouble(num1);
    double intnum2 = Convert.ToDouble(num2);
    answer = intnum1 / intnum2;
    Console.WriteLine("Ответ:");
    Console.WriteLine(answer);
}
if (action == 5)
{
    Console.WriteLine("Введите первное число");
    string num1 = Console.ReadLine();
    Console.WriteLine("Введите второе число");
    string num2 = Console.ReadLine();
    double intnum1 = Convert.ToDouble(num1);
    double intnum2 = Convert.ToDouble(num2);
    answer = Math.Pow(intnum1, intnum2);
    Console.WriteLine("Ответ:");
    Console.WriteLine(answer);
}
if (action == 6)
{
    Console.WriteLine("Введите число");
    string num1 = Console.ReadLine();
    double intnum1 = Convert.ToDouble(num1);
    answer = Math.Sqrt(intnum1);
    Console.WriteLine("Ответ:");
    Console.WriteLine(answer);
}
if (action == 7)
{
    Console.WriteLine("Введите число");
    string num1 = Console.ReadLine();
    double intnum1 = Convert.ToDouble(num1);
    answer = intnum1 * 0.01;
    Console.WriteLine("Ответ:");
    Console.WriteLine(answer);
}
if (action == 8)
{
    Console.WriteLine("Введите число");
    string num1 = Console.ReadLine();
    double intnum1 = Convert.ToDouble(num1);
    double factorial = 1;
    for (int i = 2; i <= intnum1; i++)
    {
        factorial *= i;
    }
    Console.WriteLine("Ответ:");
    Console.WriteLine(factorial);
}
if (action == 9)
{
    Environment.Exit(0);
}
}

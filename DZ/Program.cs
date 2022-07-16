void Point10()
{
    int num = new Random().Next(100, 1000);
    int scndNum = num / 10 % 10;
    Console.WriteLine("Вторая цифра случайного числа " + num + " это " + scndNum);
}
 
void Point13()
{
    int num1 = new Random().Next(0, 100000000);
    int num2 = num1;
    if (num2 > 1000) 
    {
        while (num2 > 1000) num2 = num2 / 10;
        Console.WriteLine(num2);
    }
    Console.WriteLine("Третья цифра случайного числа " + num1 + " это " + num2 % 10);

}

void Point15()
{
    Console.WriteLine("Введите порядковый номер дня недели:");
    int dayNum = Convert.ToInt32(Console.ReadLine());
    if (dayNum >= 1 && dayNum <= 7) 
    {
        if (dayNum >= 6) Console.WriteLine(dayNum + "й день недели - выходной");
        else Console.WriteLine(dayNum + "й день недели - это будний день");
    }
    else Console.WriteLine("Такого дня недели не существует");
}

//Point10();
//Point13();
//Point15();
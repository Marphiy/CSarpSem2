void Point10()
{
    int num = new Random().Next(100, 1000);
    int scndNum = num / 10 % 10;
    Console.WriteLine("Вторая цифра случайного числа " + num + " это " + scndNum);
}
 
void Point13()
{
    int num = new Random().Next(1, 1000000);
    if (num >= 100) Console.WriteLine("Третья цифра случайного числа " + num + " это " + num / 100 % 10);
    else Console.WriteLine("В числе " + num + " нет третей цифры");
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
void Point9()
{
    int number = new Random().Next(10, 100);
    int tens = number / 10;
    int ones = number % 10;
    if (tens > ones) Console.WriteLine("Десятки числа " + number + " (" + tens + ")" + " больше единиц (" + ones + ")");
    if (ones > tens) Console.WriteLine("Единицы числа " + number + " (" + ones + ") меньше чем его десятки (" + tens + ")");
    if (ones == tens) Console.WriteLine("Десятки числа " + number + " равны единицам: " + tens + " = " + ones);
}

void Point11()
{
    int number = new Random().Next(100, 1000);
    int fstNum = number / 100;
    int thrdNum = number % 10;
    int Num = fstNum * 10 + thrdNum;
    Console.WriteLine(number);
    Console.WriteLine(fstNum);
    Console.WriteLine(thrdNum);
    Console.WriteLine(Num);
}

void Point12()
{
    int number1 = new Random().Next(1, 10);
    int number2 = new Random().Next(10, 100);
    int div = number2 % number1;
    Console.WriteLine(number1);
    Console.WriteLine(number2);
    if (div == 0) Console.WriteLine("Второе число кратно первому");
    else Console.WriteLine("Остаток от деления " + number2 + " на " + number1 + " = " + div);
}

void Point14()
{
    int number = new Random().Next(100, 1000); 
    if (number % 7 == 0 && number % 23 == 0) Console.WriteLine("Число " + number + " кратно 7 и 23");
    else if (number % 7 == 0 && number % 23 != 0) Console.WriteLine("Число " + number + " кратно 7, но некратно 23");
    else if (number % 7 != 0 && number % 23 == 0) Console.WriteLine("Число " + number + " некратно 7, но кратно 23");
    else Console.WriteLine("Число " + number + " НЕкратно 7 и 23");
}

void Point16()
{
    Console.WriteLine("Enter num a");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter num b");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a == b * b || b == a * a) Console.WriteLine("Yes");
    else Console.WriteLine("No");
}


//Point9();
//Point11();
//Point12();
//Point14();
//Point16();
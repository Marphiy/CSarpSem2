
//Генератор пароля
string PassGenerate(string iPass, int count)
{
    string [] arr = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "g", "k", "l", "m", "n", "o", "p", "q", "r", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "/", "!", "?", "@", "#", "$", "%", "^", "&", "*", "(", ")"};
    Random rnd = new Random();
    int passLength = new Random().Next(8, 16);
    if (count != 0) passLength = count;
    for (int i = 0; i < passLength; i++)
    {
        iPass = iPass += arr[rnd.Next(0, 72)];
    }
    return iPass;
}

string getPass = "";
string pass = PassGenerate(getPass, 12);
for (int i = 0; i < pass.Length; i++)
{
    Console.Write(pass[i]);
}
Console.WriteLine();


string[] arr;
Console.WriteLine("Введите массив строк через пробел");
string stroka = Console.ReadLine();
arr = stroka.Split(' ');
var result = new string[arr.Length];
var realSize = 0;
foreach (var value in arr)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, result));

using static System.Console;
using System.Linq;
Clear();

WriteLine("Введите строки в массив через проблел: ");
string[] userarray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] clearedArray = ExtractLess4LettersElements(userarray);
WriteLine($"[{String.Join(" ", clearedArray)}]");



string[] ExtractLess4LettersElements(string[] array)
{
    string[] newarray = { };
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i].Length < 4)
        {
            newarray = newarray.Append(array[i]).ToArray();
        }


    }


    return newarray;
}
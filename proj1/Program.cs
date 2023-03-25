using System.Net.Security;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

string[] ModifyArray(string[] array)
{
    string[] result;
    int counIsTrueElement = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            counIsTrueElement++;
            continue;
        }
        array[i] = "";
    }

    if (counIsTrueElement == 0)
    {
        return null;
    }

    result = new string[counIsTrueElement];
    int selectIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
/*        if (array[i] == "")
        {
            result[selectIndex] = array[i];
            selectIndex++;
        }*/
        if (!array[i].Equals(""))
        {
            result[selectIndex] = array[i];
            selectIndex++;
        }
    }

    return result;
}

void PrintArray(string[] arr)
{
 /*   for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == "") i++;
        else Console.WriteLine("[" + string.Join(", ", arr[i]) + "]");
    }*/
    Console.WriteLine("[" + string.Join(", ", arr) + "]");
}
string[] myArray = { "hello", "2", "asddd", "321" };
var newMyArray = ModifyArray(myArray);
PrintArray(newMyArray);


string[] sortArray(string[] array)
{
    string[] newArray = new string[array.Length];
    for (int i = 0; i < newArray.Length; i++)
    {
        if (array[i].Length < 4) newArray[i] = array[i];
    }
    return newArray;
}
string[] a = {"12", "Paper", " ..213", "Peq", " .1"};

void PrintArray(string[] b)
{
    foreach (var el in b)
    {
        Console.Write(el + " ");
    }
}
PrintArray(sortArray(a));
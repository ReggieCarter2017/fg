
string[] sortArray(string[] array)
{
    string[] newArray = new string[array.Length];
    int count = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (array[i].Length < 4) 
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}
string[] a = {"0tyrtyrty", "Paper", " ..213", "rtyrtyrty", " rtyrtyrty.1"};

void PrintArray(string[] b)
{
    foreach (var el in b)
    {
        Console.Write(el + " ");
    }
}
PrintArray(sortArray(a));
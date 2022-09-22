string[] sortArray(string[] array)
{
    string[] newArray = new string[array.Length];
    for (int i = 0; i < newArray.Length; i++)
    {
        if (array[i].Length < 4) newArray[i] = array[i];
    }
    return newArray;
}
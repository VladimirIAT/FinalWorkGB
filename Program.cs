//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа.
//"hello", "2", "word", ":-)"
//"1234", "1567", "-2", "computer science"
//"Russia", "Denmark", "Kazan"
using static System.Console;
Clear();

string[] array = new string[] { "Russia", "Denmark", "Kazan" };
PrintArray(array);
PrintArray(createNewArray(array));

string [] createNewArray(string[] inArray)
{
    int p = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length < 4) 
        {
            p++;
        }
    }
    string[] newArray = new string[p];
    int t = 0;
    for (int j = 0; j < inArray.Length; j++)
    {
        if (inArray[j].Length < 4) 
        {
            newArray[t] = inArray[j];
            t++;
        }
    }    
    return newArray;
}

void PrintArray(string[] inArray)
{
    if (inArray.Length == 0) 
    {
        WriteLine("[]");
    } else {
        Write("[");
        for (int i = 0; i < inArray.Length - 1; i++)
            {
                Write($"{inArray[i]},");
            }
        Write($"{inArray[inArray.Length - 1]}]");
        }

}
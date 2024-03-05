Console.WriteLine("Введите размер массива строк:");

int size = Convert.ToInt32(Console.ReadLine());

string[] FillArrayOfStrings(int size)
{
    string[] arrayOfStrings = new string[size];

    for(int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1}-й элемент массива:");
        arrayOfStrings[i] = Console.ReadLine()!;
    }
    return arrayOfStrings;
}

string[] SortArray(string[] arrayOfStrings)
{
    string temp = string.Empty;

    for(int i = 0; i < arrayOfStrings.Length - 1; i++)
    {
        for(int j = 0; j < arrayOfStrings.Length - i - 1; j++)
        {
            if (arrayOfStrings[j].Length > arrayOfStrings[j + 1].Length)
            {
                temp = arrayOfStrings[j];
                arrayOfStrings[j] = arrayOfStrings[j + 1];
                arrayOfStrings[j + 1] = temp;
            }
        }
    }
    return arrayOfStrings;
}

string[] GetNewStringArray(string[] arrayOfStrings)
{

    int count = 0;

    for(int i = 0; i < arrayOfStrings.Length; i++)
    {
        if (arrayOfStrings[i].Length <= 3)
        {
            count = count + 1;
        }
    }

    string[] newArrayOfStrings = new string[count];
    
    for (int i = 0; i < count; i++)
    {
        if (arrayOfStrings[i].Length <= 3)
        {
            newArrayOfStrings[i] = arrayOfStrings[i];
        }
    }
    return newArrayOfStrings;
}

void ShowArray(string[] arrayOfStrings, string[] newArrayOfStrings)
{
    Console.WriteLine($"Исходный массив: [{string.Join(", ", arrayOfStrings)}]");
    Console.WriteLine($"Новый массив: [{string.Join(", ", newArrayOfStrings)}]");
}

string[] arrayOfStrings = SortArray(FillArrayOfStrings(size));
string[] newArrayOfStrings = GetNewStringArray(arrayOfStrings);

ShowArray(arrayOfStrings, newArrayOfStrings);
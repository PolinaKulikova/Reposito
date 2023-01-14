// Считать от пользователя данные
int GetNumberByUser(string text)
{
    Console.WriteLine(text + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

// Создание массива
int[] CreateArray(int size)
{
   return new int[size+1]; 
}

// Метод получения кубов чисел
void GetCubes(int[] collectionNumber)
{
   int count = collectionNumber.Length;
   for (int i = 0; i < count; i++)
   {
    collectionNumber[i]= i * i * i;
   } 
}

// Распечатать результат
string Print(int[] numbers)
{
    string output = String.Empty;
    int size = numbers.Length;

    for (int i = 0; i < size; i++)
    {
      output = output + $"{i}^3 = {numbers[i]}\n";  
    }
    return output;
}

int countByUser = GetNumberByUser("Введите N");
int[] array = CreateArray(countByUser);
GetCubes(array);
string result = Print(array);
Console.WriteLine(result);

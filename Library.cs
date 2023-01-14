public static class Library
{
    // Считать от пользователя данные
public static int GetNumberByUser(string text)
{
    Console.WriteLine(text + ": ");
    return Convert.ToInt32(Console.ReadLine());
}
}
// Создание массива
public static int[] CreateArray(int size)
{
   return new int[size+1]; 
}

// Метод получения кубов чисел
public static void GetCubes(int[] collectionNumber)
{
   int count = collectionNumber.Length;
   for (int i = 0; i < count; i++)
   {
    collectionNumber[i]= i * i * i;
   } 
}

// Распечатать результат
public static string Print(int[] numbers)
{
    string output = String.Empty;
    int size = numbers.Length;

    for (int i = 0; i < size; i++)
    {
      output = output + $"{i}^3 = {numbers[i]}\n";  
    }
    return output;
}
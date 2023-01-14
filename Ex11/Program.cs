 void FillArray(int[] collection)      // Метод заполнения массива случайными числами от 1 до 10
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);             //Положить случайное число от 1 до 10 в каждый элемент массива
        index++;
    }
}

void PrintArray(int[] collection)     // Метод печати массива
{
    int count = collection.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine(collection[position]);
        position++; 
     }
} 


int[] array = new int[10];   // new int[10] создание случайного массива из 10 элементов int = 0  

FillArray(array);                     // Вызов метода заполнения  массива
PrintArray(array);                    // Вызов метода печати массива
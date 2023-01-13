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


int[] array = new int[10];   // new int[10] создание случайного массива из 10 элементов int = 0  


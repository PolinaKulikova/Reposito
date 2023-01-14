// Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find
// 1. Установить счетчик index в позицию 0
// 2. Если array[index]= find, то алгоритм завершил работу успешно
// 3.Увеличить индекс на 1
// 4.Если index < n, то перейти к шагу 2. Иначе алгоритм завершил работу безуспешно

int[] array = { 1, 12, 31, 4, 15, 16, 17, 18};
int n = array.Length;
// int find = 18;
int index = 0;

// while (index<n)                    // Нахождение индекса искомого заранее известного элемента find
// {
    
//     if ((array[index] == find))
//     {
//         Console.WriteLine(index);
//         break;                      // Если таких значений в массиве несколько, прервать алгоритм после нахождения первого
//     } 
//     index = index+1;
// }
                                                    // Метод нахождения индекса искомого элемента в массиве   
int IndexOf(int[] collection, int find)      
{
    int count = collection.Length;                 
    int index = 0;
    int position = -1;                              // Значение -1 считаем ошибкой, если значение не будет найдено в массиве, программа выдаст -1, а не ноль
    while (index<count)
    {
    if (collection[index] == find)
    {
        position = index;
        break;                             //Перестать искать после находжения первого
    }
        index++;
    }
    return position;
}    

double inputValue()                                                //Метод проверки на дурака               
{
    double result;
    while (!double.TryParse(Console.WriteLine(), out result));
    return result;
}

int pos = IndexOf(array, 4);
Console.WriteLine(pos);

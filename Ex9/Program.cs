// Найти максимум из элементов массива

int[] array = { 11, 21, 3111, 41, 15, 61, 17, 18, 19 };

int Max(int arg1, int arg2, int arg3) // метод нахождения максимума с разбивкой на 3 группы
{
    int result = arg1;
    if (result < arg2) result = arg2; 
    if (result < arg3) result = arg3; 
    return result;
}
 int max = Max(                          // назначаем переменной  max максимальное значение
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);

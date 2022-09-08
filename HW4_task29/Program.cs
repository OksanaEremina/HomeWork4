 // Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран;
 // пользователь вводит число элементов в массиве и минимальное, и максимальное значение;
 // надо заполнить массив рандоными данными от минимального до максимального значение. И важное уточнение, делать все в методе,
 // который возвращает массив.
 // 5, 1, 20 -> [1, 2, 5, 7, 19]

 // 3, 1, 33 -> [6, 1, 33]

    int[] createRandomArray(int length, int minValue, int maxValue) 
    {
    
        int[] result = new int[length];
    
    Random objectOfRandomClass = new Random();
    for (int i = 0; i < length; ++i) {
            
            int randomNumber = objectOfRandomClass.Next(minValue, maxValue);
    result[i] = randomNumber;
        }
        return result;
    }
    Console.WriteLine("Введите количество чисел: ");
        int length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите минимально возможное число в массиве: ");
        int minValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите максимально возможное число в массиве: ");
        int maxValue = Convert.ToInt32(Console.ReadLine());
        int[] result = createRandomArray(length, minValue, maxValue);
        Console.WriteLine("Результат: [{0}]",string.Join(", ",result));
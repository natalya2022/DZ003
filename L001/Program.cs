// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом.

int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}

int[] arrayString(int value1)                         // Функция переводит число в массив  
{
    string str = value1.ToString();
    int[] value2 = new int[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        value2[i] = int.Parse(str[i].ToString());
    }
    return value2;
}

int value1 = Prompt("Введите пятизначное число >");                // Вводим значение

if (value1 >= 10000 && value1 <= 99999)
{
    int[] array = arrayString(value1);
    for (int i = 0; i < array.Length; i++)                         // Печать массива в целях отладки
    {
        System.Console.Write(array[i] + " ");
    }
    if (array[0] == array[4] && array[1] == array[3])
    {
        System.Console.WriteLine("Это палиндром");
    }
    else
    {
        System.Console.WriteLine("Это НЕ палиндром");
    }
}
else
{
    System.Console.WriteLine("Число не является пятизначным");
}

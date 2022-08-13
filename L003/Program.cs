// Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.

int Prompt(string message)
{
    System.Console.Write(message);                      // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine());   // Считывает значение
    return result;                                      // Возвращает результат
}


void CubeTable(int num)                                 // Функция считает куб и выводит на экран
{
    if (num >= 1)                                       // Проверка диапазона
    {
        int i = 1;
        while (i <= num)
        {
            System.Console.Write(i * i * i + " ");
            i++;
        }
    }
    else
    {
        System.Console.WriteLine("Число не соответствует условию");
    }
}

CubeTable(Prompt("Введите число : "));
// Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.

double Distance(int x1, int y1,
                int z1, int x2,
                int y2, int z2)
{
    double dis = Math.Pow((Math.Pow(x2 - x1, 2) +           // Функция вычисляет расстояние
                           Math.Pow(y2 - y1, 2) +
                           Math.Pow(z2 - z1, 2)), 0.5);
    return dis;
}

int Prompt(string message)
{
    System.Console.Write(message);                      // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine());   // Считывает значение
    return result;                                      // Возвращает результат
}

int x1 = Prompt("Введите координаты первой точки: Х > ");        // Вводим значения
int y1 = Prompt("Введите координаты первой точки: Y > ");
int z1 = Prompt("Введите координаты первой точки: Z > ");
int x2 = Prompt("Введите координаты второй точки: Х > ");        
int y2 = Prompt("Введите координаты второй точки: Y > ");
int z2 = Prompt("Введите координаты второй точки: Z > ");

double dis = Distance(x1, y1, z1, x1, y2, z2);
System.Console.WriteLine(dis);







Console.Write("Введите номер задания: ");
int task = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"\nЗадание №{task}\n");

switch(task)
{
    case 47:
        task47();
        break;

    case 50:
        task50();
        break;

    case 52:
        task52();
        break;

    default:
        break;
}

dynamic CreationArray()
{   
    Console.Write("Укажите желаемое кол-во строк в двумерном массиве: ");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.Write("Укажите желаемое кол-во столбцов в двумерном массиве: ");
    int column = Convert.ToInt32(Console.ReadLine());
    
    if(task == 47)
    {
        double[,] array = new double[line, column];
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {   
                Random r = new Random();
                array[i,j] = Math.Round(r.Next(-10,10) * r.NextDouble(), 1);
                Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine(" ");
        }
        return array;
    }
    else
    {
        int[,] array = new int[line, column];
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {   
                Random r = new Random();
                array[i,j] = r.Next(10);
                Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine(" ");
        }   
        return array;   
    }
    
}   


void task47()
{
   CreationArray();
}

void task50()
{
    void SearchNum(int[,] array ,int num)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i,j] == num)
                {
                    Console.WriteLine($"Элемент со значением {num} находится на позиции ({i}, {j})");
                    return;
                }
            }
        }
        Console.WriteLine("Такого элемента в данном масиве нет");
    }   
    
    int[,] array = CreationArray();

    Console.Write("Введите значение элемента которое будем искать в масиве: ");
    int num = Convert.ToInt32(Console.ReadLine());

    SearchNum(array ,num);
}

void task52()
{
    double sum = 0;
    int[,] array = CreationArray();

    Console.Write("Среднее арифметическое каждого столбца: ");
    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        Console.Write($"{sum / array.GetLength(0)}; ");
        sum = 0;
    }
}
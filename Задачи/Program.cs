// =====            Домашка 26.09.22
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)      2, 4 -> 16

// Console.WriteLine("");
// Console.WriteLine("Введите число A: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число B: ");
// int B = int.Parse(Console.ReadLine()!);
// int result = A;
// for(int num = 1; num < B; num++)
// {
//      result = result * A;
// }
// Console.WriteLine($"{result}");

 



//=Задача 27:
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11      82 -> 10        9012 -> 12

// Console.WriteLine("");
// Console.Write("Введите число: ");
// int numN = Convert.ToInt32(Console.ReadLine());
// int SumNum(int numN)
//   {
//     int counter = Convert.ToString(numN).Length;
//     int advance = 0;
//     int result = 0;
//     for (int i = 0; i < counter; i++)
//     {
//       advance = numN - numN % 10;
//       result = result + (numN - advance);
//       numN = numN / 10;
//     }
//    return result;
//   }
// int sumNum = SumNum(numN);
// Console.WriteLine("Сумма цифр в числе: " + sumNum);



//=Задача 29: 
//Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]             6, 1, 33 -> [6, 1, 33]

void GetArray(int[] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(1, 100);
        Console.Write(array[index]  + ", ");
    }
}
int[] array = new int[8];
GetArray(array);































































void Method1() 
{
     Console.WriteLine("");
     Console.WriteLine("С уважением, Евгений Ткаченко!");
     Console.WriteLine("");
}
Method1();
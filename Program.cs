// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int Test(){
//     int num = Convert.ToInt32(Console.ReadLine());
//     int dec = num % 100;
//     int one = dec % 10;
//     int second = (dec - one) / 10;
//     return second;
// }
// Console.WriteLine("Введите трехзначное число: ");
// int res = Test();
// Console.WriteLine($"Вторая цифра числа - {res}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



void Stuff(int num){
    while (num > 999)
        num = num/10;
/////        Console.WriteLine($"Третье число - {num%10}");
    if (num < 100)
        Console.WriteLine("Третьей цифры нет");
    else
        Console.WriteLine($"Третье число - {num%10}");
        
}
Console.WriteLine("Введите число");
int ent = Convert.ToInt32(Console.ReadLine());
Stuff(ent);



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


// void Day(int num){
//     if (num < 6)
//         Console.WriteLine("Будний день");
//     else if (num > 7)
//         Console.WriteLine("Попробуйте еще раз ввести целое число от 1 до 7");
//     else
//         Console.WriteLine("Выходной день");
// }
// Console.WriteLine("Введите целое число от 1 до 7");
// int num = Convert.ToInt32(Console.ReadLine());
// Day (num);
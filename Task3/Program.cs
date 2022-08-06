// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите целое число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine()); // -2 147 483 648 до 2 147 483 647
string day ="";
//if (number>=1 && number <=7)
//{
    switch(number)
    {
    case 1:
        day = "Понедельник";
        break;
    case 2:
        day = "Вторник";
        break;
    case 3:
        day = "Среда";
        break;
    case 4:
        day = "Четверг";
        break;
    case 5:
        day = "Пятница";
        break;
    case 6:
        day = "Суббота";
        break;
    case 7:
        day = "Воскресенье";
        break;
    default:                                                    //закомментарить эти строки
        Console.WriteLine("Вы ввели некорректное число");       //закомментарить эти строки
        break;                                                  //закомментарить эти строки
    }
    Console.WriteLine($"День недели номер {number} -- {day}");
//}
// else
// {
//     Console.WriteLine("Вы ввели некорректное число");
// }
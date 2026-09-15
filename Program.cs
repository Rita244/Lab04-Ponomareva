// int age = 20;
// if (age >= 21) {
//     Console.WriteLine("Доступ разрешён");
// }
// Console.WriteLine("Программа продолжает работу");

// int age = 15;
// if (age >= 18) {
//     Console.WriteLine("Доступ разрешён");
// } else {
//     Console.WriteLine("Доступ запрещён");
//     Console.WriteLine($"Осталось ждать: {18 - age} лет");
// }

// int age = 60; 
// if (age < 13)
// {
// Console.WriteLine("Ребёнок");
// }
// else if (age < 18)
// {
// Console.WriteLine("Подросток");
// }
// else if (age >= 60)
// {
// Console.WriteLine("Пенсионер");
// }
// else
// {
// Console.WriteLine("Взрослый");
// }
// int age = 16;
// double height = 1.55;

// if (age >= 14 && height >= 1.5) {
//     Console.WriteLine("Можно кататься");
// } else {
//     Console.WriteLine("Пока нельзя");
// }

// int age = 16;
// double height = 1.4;
// bool hasAdult = true;
// if ((age >= 14 && height >= 1.5) || hasAdult == true) {
//     Console.WriteLine("Можно кататься");
// } else {
//     Console.WriteLine("Пока нельзя");
// }

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// if (num % 2 == 0)
// {
// Console.WriteLine("Число чётное");
// }
// else
// {
// Console.WriteLine("Число нечётное");
// }

// Console.Write("Введите оценку (2-5): ");
// int grade = int.Parse(Console.ReadLine());
// switch (grade)
// {
// case 5: Console.WriteLine("Отлично"); break;
// case 4: Console.WriteLine("Хорошо"); break;
// case 3: Console.WriteLine("Удовлетворительно"); break;
// case 2: Console.WriteLine("Неудовлетворительно"); break;
// default: Console.WriteLine("Неверная оценка"); break;
// }

Console.Write("Введите ваш возраст: ");
int age = int.Parse(Console.ReadLine());
if (age >= 18)
{
Console.WriteLine("Доступ разрешён");
}
else
{
Console.WriteLine("Доступ запрещён");
}
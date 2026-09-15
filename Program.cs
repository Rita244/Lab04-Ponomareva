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
// if (age < 13) {
//     Console.WriteLine("Ребёнок");
// } else if (age < 18) {
//     Console.WriteLine("Подросток");
// } else if (age >= 60) {
//     Console.WriteLine("Пенсионер");
// } else {
//     Console.WriteLine("Взрослый");
// }

// int age = 16;
// double height = 1.55;

// if (age >= 14 && height >= 1.5) {
//     Console.WriteLine("Можно кататься");
// } else {
//     Console.WriteLine("Пока нельзя");
// }

int age = 16;
double height = 1.4;
bool hasAdult = true;
if ((age >= 14 && height >= 1.5) || hasAdult == true) {
    Console.WriteLine("Можно кататься");
} else {
    Console.WriteLine("Пока нельзя");
}
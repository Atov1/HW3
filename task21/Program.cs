//Напишите программу, которая принимает на вход координаты
//двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

// d = √((хА –  хВ)2 + (уА – уВ)2 + (zA-zB)2)

Console.Write("Введите координату X первой точки: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y первой точки: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату Z первой точки: ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату X второй точки: ");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y второй точки: ");
int y2 = int.Parse(Console.ReadLine());

Console.Write("Введите координату Z второй точки: ");
int z2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Длина отрезка =  {Math.Round(Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2) + Math.Pow((z1-z2), 2)), 2)}");
// в целом, эта задача практически не изменилась с задачи на семинаре, только добавилась координата Z, а так формула та же
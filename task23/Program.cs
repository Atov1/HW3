Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int J = 1; // (число начала отсчета) по условию задачи, счетчик равен 1

Console.Write($"{N} -> ");

if (N > 0) // проверка знака перед числом (+/-)
{
while (J < N) //решение если число положительное
{
    Console.Write($"{Math.Pow(J, 3)}, ");
    J++;
}
if (J==N)
{
    Console.Write($"{Math.Pow(J, 3)}");
}}
else //решение, если число отрицательное
{
    J = -1;
    while (J > N)
{
    Console.Write($"{Math.Pow(J, 3)}, ");
    J--;
}
if (J==N)
{
    Console.Write($"{Math.Pow(J, 3)}");
}}

Console.WriteLine("Введите цифру от 1 до 7: ");
int num = int.Parse(Console.ReadLine());
while (num > 7 || num < 1)
 {
    Console.WriteLine("Введите цифру от 1 до 7: ");
    num = int.Parse(Console.ReadLine());
 }

if (num == 6 || num == 7)
{
    Console.WriteLine("Выходной :)");
}
else
{
    Console.WriteLine("Будний :(");
}

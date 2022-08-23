Console.WriteLine("Введите трёхзначное число: ");
int a = int.Parse(Console.ReadLine());

while (a < 99 || a > 999)
 {
    Console.WriteLine("Введите трёхзначное число: ");
    a = int.Parse(Console.ReadLine());
 }

int b = (a % 100);
Console.WriteLine(b / 10);
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
if(max < b) max = b;

Console.Write("Максимальное число:");
Console.Write(max);
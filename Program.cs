// Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

Console.Clear();
Console.WriteLine("Введите высоту елочки: ");
int n = int.Parse(Console.ReadLine()!);
int count = 0;
int x = 50;
int y = 1;
int y1 = y;
int x2 = x;
int x1 = x;
Console.SetCursorPosition(x,y);
Console.WriteLine("*");
while(count <= n)
{
    y1 = y1 + 1; 
    {
        Console.SetCursorPosition(x,y1);  
        Console.WriteLine("*");
        x1 = x1 - 1;
        x2 = x2 + 1;
        {
            Console.SetCursorPosition(x1,y1); 
            Console.WriteLine("*");
            Console.SetCursorPosition(x2,y1); 
            Console.WriteLine("*");
        }

    }
    count++;
}

/*Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).*/
int GetQuarter()
{
    while(true)
    {
        Console.WriteLine("Введите четверть, чей диапазон хотите узнать: ");
        int quarter = Convert.ToInt32(Console.ReadLine());
        if(quarter != 1 && quarter != 2 &&quarter != 3 &&quarter != 4)
        {
            Console.WriteLine("Введите число 1,2,3 или 4: ");
        }
        else
            return quarter;
    }    
}
void GetRange(int quarter)
{
    if(quarter ==1) Console.WriteLine("x > 0, y > 0");
    else if(quarter ==2) Console.WriteLine("x < 0, y > 0");
    else if(quarter ==3) Console.WriteLine("x < 0, y < 0");
    else  Console.WriteLine("x > 0, y < 0");
}
int giveQuarter = GetQuarter();
GetRange(giveQuarter);


//ДЗ, 2 задача

int number = 45879778; 
int searchDigit = 3; 
int count = 0; 
int temp = number; 
while(temp > 0) 
{     
    temp /= 10;     
    count++; 
}  
while(count > searchDigit) 
{     
    number /= 10;
    count--; 
}  
Console.WriteLine(number%10);

//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),  
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int x = ReadInt("Введите точку x: "); 
int y = ReadInt("Введите точку y: ");  
if(x == 0 || y == 0) 
{     
    Console.WriteLine("x и y не могут быть равны 0");     
    return; 
}  
if (x > 0 && y > 0) 
{     
    Console.WriteLine("1"); 
} 
else if(x < 0 && y > 0) 
{     
    Console.WriteLine("2"); 
} 
else if(x < 0 && y < 0) 
{     
    Console.WriteLine("3"); 
} 
else if(x > 0 && y < 0) 
{     
    Console.WriteLine("4"); 
}  
int ReadInt(string message) //для всех последующих задач
{     
    Console.Write(message);     
    return Convert.ToInt32(Console.ReadLine()); 
}

//ВАРИАНТ 2:
while(true) 
{     
    int X = ReadInt("Введите точку x: ");     
    int Y = ReadInt("Введите точку y: ");      
    if(X == 0 || Y == 0)     
    {         
        Console.WriteLine("x и y не могут быть равны 0");         
        continue;     
    }      
    if (X > 0 && Y > 0)     
    {         
        Console.WriteLine("1");     
    }     
    else if(X < 0 && Y > 0)     
    {         
        Console.WriteLine("2");     
    }     
    else if(X < 0 && Y < 0)     
    {         
        Console.WriteLine("3");     
    }     
    else if(X > 0 && Y < 0)     
    {         
        Console.WriteLine("4");     
    }     
    break; 
}   

//18. Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

int quarter = ReadInt("Введите номер четверти: "); 
if(quarter == 1) 
{     
    Console.WriteLine("x > 0, y > 0"); 
} 
else if(quarter == 2) 
{     
    Console.WriteLine("x < 0, y > 0"); 
} 
else if(quarter == 3) 
{     
    Console.WriteLine("x < 0, y < 0"); 
} 
else if(quarter == 4) 
{     
    Console.WriteLine("x > 0, y < 0"); 
} 
else 
{     
    Console.WriteLine("Четвертей всего 4!"); 
}   

//ВАРИАНТ 2:
int Quarter = ReadInt("Введите номер четверти: "); 
switch (Quarter) 
{     
    case 1:         
    Console.WriteLine("x > 0, y > 0");         
    break;     
    case 2:         
    Console.WriteLine("x < 0, y > 0");         
    break;     
    case 3:         
    Console.WriteLine("x < 0, y < 0");         
    break;     
    case 4:         
    Console.WriteLine("x > 0, y < 0");         
    break;     
    default:         
    Console.WriteLine("Четвертей всего 4!");         
    break; 
}  

//КОРЕНЬ:
int Number = 9; 
double result = Math.Sqrt(Number); 
Console.WriteLine(result);

//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве. 
//A (3,6); B (2,1) -> 5,09  A (7,-5); B (1,-1) -> 7,21

int aX = ReadInt("Введите координату X точки A: "); 
int aY = ReadInt("Введите координату Y точки A: "); 
int bX = ReadInt("Введите координату X точки B: "); 
int bY = ReadInt("Введите координату Y точки B: ");  
int sqrSideX = (aX - bX) * (aX - bX); 
int sqrSideY = (aY - bY) * (aY - bY); 
double distance = Math.Sqrt(sqrSideX + sqrSideY); 
Console.WriteLine(distance);  

//Напишите программу, которая принимает на вход число (N) и выдаёт 
//таблицу квадратов чисел  от 1 до N. 5 -> 1, 4, 9, 16, 25. 2 -> 1,4

int Num = ReadInt("Введите число: "); 
int i = 1; 
while(i <= Num) 
{     
    Console.Write(i*i + " ");     
    i++; 
}  
/*
//ВАРИАНТ 2:
int num = ReadInt("Введите число: "); 
int i = 1; 
while(i <= num) 
{     
    Console.Write(i*i++ + " "); 
}  

//ВАРИАНТ 3:
int numb = ReadInt("Введите число: "); 
int i = 1; 
while(i <= numb) 
{     
    Console.Write(Pow(i++) + " "); 
}  
int Pow(int a) 
{     
    return a * a; 
}  
*/
// ФАКТОРИАЛ 
/*int Factorial(int n)
{
    // 1! - обозначение факториала
    // 1! = 1 факториал 1 равен 1
    // 0! = 1 факториал 0 равен 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(40)); // 1*2*3 = 6 */

// ФАКТОРИАЛ с циклом
/*int*/ double Factorial(int n)
{                  
    if (n == 1) return 1; //РЕКУРСИЯ - когда метод использует сам себя
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)  
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
/* получаем с 17! = -288522240 - невозможный результат, 
что связано с переполнением типа:
РЕШЕНИЕ:
1). использовать double вместо int 
2). есть другие способы*/

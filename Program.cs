// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами

 Console.Clear();
 string [] arrey=new string [] {"hello", "world", "2", "C#", ":-)" };
 string [] finisharrey=new string [arrey.Length];
 
 void FillArrey (string [] arrey, string [] finisharrey)
 {
    int x = 3;
    for (int i=0; i<arrey.Length; i++)
    {
        {
        if (arrey[i].Length <= x)
        finisharrey[i]=arrey [i];
        }
    }    
 }
 void PrintArrey (string [] arrey)
 {
    for (int i=0; i<arrey.Length; i++)
    {Console.Write ($"{arrey[i]}  ");}
 }

PrintArrey (arrey);
FillArrey (arrey, finisharrey);
Console.WriteLine();
PrintArrey (finisharrey);



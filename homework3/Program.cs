/*Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

/*Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число - палиндром.");
  }
  else Console.WriteLine($"Ваше число - не палиндром.");
}

if (number!.Length == 5){
  CheckNumber(number);
}
else Console.WriteLine($"Введи правильное число");
*/


/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
 A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*

Console.WriteLine("Введите X координату точки А");
double xa =  double.Parse(Console.ReadLine());

Console.WriteLine("Введите Y координату точки А");
double ya =  double.Parse(Console.ReadLine());

Console.WriteLine("Введите X координату точки B");
double xb =  double.Parse(Console.ReadLine());

Console.WriteLine("Введите Y координату точки B");
double yb =  double.Parse(Console.ReadLine());

Console.WriteLine("Введите Z координату точки A");
double za =  double.Parse(Console.ReadLine());

Console.WriteLine("Введите Z координату точки B");
double zb =  double.Parse(Console.ReadLine());

double result = GetResult(xa, ya, za, xb, yb, zb);


Console.WriteLine($"Расстояние между точками {result}");


double GetResult (double xa, double ya, double xb, double yb, double za, double zb )
{
    return Math.Sqrt(Math.Pow((xb -xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
}
*/


/*Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
 3 -> 1, 8, 27
 5 -> 1, 8, 27, 64, 125
*/

/*Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    Console.WriteLine(i * i * i);
}
*/
/*
Console.WriteLine("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());

void Cube(int[] i){
  int counter = 1;
  int length = i.Length;
  while (counter <  length){
    i[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 1;
  while(index < count){
    Console.WriteLine(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[i++];
Cube(arry);
PrintArry(arry);

*/

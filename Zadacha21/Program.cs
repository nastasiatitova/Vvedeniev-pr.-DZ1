//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int[] pointsa = new int[3];

Console.WriteLine("Введите коордитаты x, y и z для точки А");
for (int ia = 0; ia < pointsa.Length; ia = ia + 1)
    pointsa[ia] = Convert.ToInt32(Console.ReadLine());

int[] pointsb = new int[3];

Console.WriteLine("Введите коордитаты x, y и z для точки Б");
for (int ib = 0; ib < pointsb.Length; ib = ib + 1)
    pointsb[ib] = Convert.ToInt32(Console.ReadLine());

int A = pointsa[0]- pointsb[0];
int B = pointsa[1]- pointsb[1];
int C = pointsa[2]- pointsb[2];

double result = Math.Sqrt( Math.Pow(A , 2) + Math.Pow(B , 2 ) + Math.Pow(C , 2)) ;
Console.WriteLine("Расстояние равно " + Math.Round (result,2));
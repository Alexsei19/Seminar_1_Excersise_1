// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 
// 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Программа  принимает на вход координаты двух точек и находит  расстояние между ними в 3D пространстве" );
int xa,ya,za,xb,yb,zb;
Console.WriteLine("Введите координату X точки A: ");
while(!int.TryParse(Console.ReadLine(),out xa))
{
Console.WriteLine("Введен неверный параметр ");
}
Console.WriteLine("Введите координату Y точки A: ");
while(!int.TryParse(Console.ReadLine(),out ya))
{
Console.WriteLine("Введен неверный параметр ");
}
Console.WriteLine("Введите координату Z точки A: ");
while(!int.TryParse(Console.ReadLine(),out za))
{
Console.WriteLine("Введен неверный параметр ");
}
Console.WriteLine("Введите координату X точки B: ");
while(!int.TryParse(Console.ReadLine(),out xb))
{
Console.WriteLine("Введен неверный параметр ");
}
Console.WriteLine("Введите координату Y точки B: ");
while(!int.TryParse(Console.ReadLine(),out yb))
{
Console.WriteLine("Введен неверный параметр ");
}
Console.WriteLine("Введите координату Z точки B: ");
while(!int.TryParse(Console.ReadLine(),out zb))
{
Console.WriteLine("Введен неверный параметр ");
}
double Distance(double xa,double ya,double za,double xb,double yb,double zb)
{
double result=Math.Sqrt(Math.Pow((xb-xa),2)+Math.Pow((yb-ya),2)+Math.Pow((zb-za),2));
return result;
}
double res=Distance(xa,ya,za,xb,yb,zb);
Console.WriteLine("Расстояние между двумя точками "+ res.ToString("0.##"));
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Program
    {
        static void Main()
        {
			//Разработать статический класс для работы с окружностью.Класс должен содержать 3 метода:
			//метод, определяющий длину окружности по заданному радиусу;
			//метод, определяющий площадь круга по заданному радиусу;
			//метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.
			try
			{
				Console.Write("Введите радиус окружности: ");
				double Radius = Convert.ToDouble(Console.ReadLine());

				Console.Write("Введите координат точки X: ");
				double coordinateX = Math.Abs(Convert.ToDouble(Console.ReadLine()));
				Console.Write("Введите координат точки Y: ");
				double coordinateY = Math.Abs(Convert.ToDouble(Console.ReadLine()));
				Circle.GetСircumference(Radius);
				Circle.GetSquare(Radius);
				Circle.GetPosition(Radius, coordinateX, coordinateY);
			}
			catch (FormatException)
			{
				Console.WriteLine("Ошибочный ввод. Указано вместо зяпятой, точка");
				Console.ReadKey();
				return;
			}
		}
    }
	static class Circle
	{
		public static void GetСircumference(double Radius)
		{
			double Сircumference = Math.PI * 2 * Radius;
			Console.WriteLine("Длина окружности = {0:f2}", Сircumference);
		}
		public static void GetSquare(double Radius)
		{
			double Square = Math.PI * Math.Pow(Radius, 2.0);
			Console.WriteLine("Площадь круга = {0:f2}", Square);
		}
		public static void GetPosition(double Radius, double coordinateX, double coordinateY)
		{
			if (coordinateX <= Radius && coordinateY <= Radius)
			{
				Console.WriteLine("Точка с координатами ({0},{1}) принадлежит кругу с радиусом {2}", coordinateX, coordinateY, Radius);
			}
			else
			{
				Console.WriteLine("Точка с координатами ({0},{1}) не принадлежит кругу с радиусом {2}", coordinateX, coordinateY, Radius);
			}
			Console.ReadKey();
		}
	}
}  

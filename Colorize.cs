using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Pastel;

namespace Задание_5
{
	internal class Colorize
	{
		int r, g, b;
		int x, y;
		int choose = 3;

		public void Result()
		{
			Console.WriteLine($"Выбранные цвет: R - {r}, G - {g}, B - {b}" +
							  $"\nПример цвета: {"ПРИМЕР ЦВЕТА".Pastel(Color.FromArgb(r, g, b))}" +
							  $"\nКоординаты точки: [{x}, {y}]" +
							  $"\nЗакрыть? - [1] - да, [2] - изменить выбор");
			choose = int.Parse(Console.ReadLine());
			switch (choose)
			{
				case 1:
					Environment.Exit(0);
					break;
				case 2:
					Change();
					break;

			};

		}

		public void Change()
		{
			choose = 3;
			while (choose > 0)
			{
				switch (choose)
				{
					case 3:
						{
							Console.WriteLine("Введите значение для красного цвета от 0 до 255");
							r = int.Parse(Console.ReadLine());
							while (r < 0 || r > 255)
							{
								Console.WriteLine("Вне диапазона");
								r = int.Parse(Console.ReadLine());
							}
							Console.WriteLine("Введите значение для зеленого цвета от 0 до 255");
							g = int.Parse(Console.ReadLine());
							while (g < 0 || g > 255)
							{
								Console.WriteLine("Вне диапазона");
								g = int.Parse(Console.ReadLine());
							}
							Console.WriteLine("Введите значение для голубого цвета от 0 до 255");
							b = int.Parse(Console.ReadLine());
							while (b < 0 || b > 255)
							{
								Console.WriteLine("Вне диапазона");
								b = int.Parse(Console.ReadLine());
							}
							Console.WriteLine($"Выбранный цвет: {"ПРИМЕР ЦВЕТА".Pastel(Color.FromArgb(r, g, b))}." +
											  $"Продолжить? [1] - да, [2] - изменить ");
							choose = int.Parse(Console.ReadLine());
						}
						break;
					case 2: choose = 3; break;
					case 1:
						{
							Console.WriteLine("Введите координаты точки");
							Console.Write("X: ");
							x = int.Parse(Console.ReadLine());
							Console.Write("Y: ");
							y = int.Parse(Console.ReadLine());
								Result();
						}
						break;	
				};
			}
			
		}
		public Colorize(int r, int g, int b)
		{
			this.r = r;
			this.g = g;
			this.b = b;	
		}
		public Colorize()
		{
		}
	}
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForStarStaff_AreaOfARectangle;

namespace AreaOfARectangle_Tests
{
	[TestClass]
	public class AreaOfARectangleTests
	{
		/// <summary>
		/// Тест создания нового класса RightTriangle через пустой конструктор и 
		/// выполнение расчета площади прямоугольного треугольника.
		/// </summary>
		[TestMethod]
		public void CreatingRightTriangleWithEmptyConstructorAndAreaCalculatingWith543()
		{
			RightTriangle rightTriangle = new RightTriangle();
			rightTriangle.AreaCalculation(5, 4, 3);
		}

		/// <summary>
		/// Тест создания нового класса RightTriangle через конструктор по 3 сторонам и 
		/// выполнение расчета площади прямоугольного треугольника.
		/// </summary>
		[TestMethod]
		public void CreatingRightTriangleWithConstructorAndAreaCalculatingWith543()
		{
			RightTriangle rightTriangle = new RightTriangle(5, 4, 3);
			rightTriangle.AreaCalculation();
		}

		/// <summary>
		/// Тест создания нового класса RightTriangle через пустой конструктор и 
		/// выполнение расчета площади прямоугольного треугольника с неверными сторонами.
		/// </summary>
		[TestMethod]
		public void CreatingTriangleWithConstructorAndAreaCalculatingWithWrongData()
		{
			RightTriangle rightTriangle = new RightTriangle();
			Console.WriteLine(rightTriangle.AreaCalculation(5.34, 4, 3));
		}
	}
}

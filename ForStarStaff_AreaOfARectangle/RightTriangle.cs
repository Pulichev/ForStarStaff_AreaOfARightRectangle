using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForStarStaff_AreaOfARectangle
{
	/// <summary>
	/// Класс прямоугольного треугольника.
	/// Содержит 3 переменные(два катета и гипотенузу).
	/// В рамках задания содержит только метод вычисления площади.
	/// </summary>
	public class RightTriangle
	{
		#region Variables

		private double _hypotenuse; //Гипотенуза.
		private double _firstCathetus; //Первый катет.
		private double _secondCathetus; //Второй катет.

		#endregion

		/// <summary>
		/// Конструктор, принимающий длину всех 3 сторон.
		/// </summary>
		/// <param name="hypotenuse">Значение гипотенузы.</param>
		/// <param name="firstCathetus">Значение первого катета.</param>
		/// <param name="secondCathetus">Значение второго катета.</param>
		public RightTriangle(object hypotenuse, object firstCathetus, object secondCathetus)
		{
			try
			{
				_hypotenuse = Convert.ToDouble(hypotenuse);
				_firstCathetus = Convert.ToDouble(firstCathetus);
				_secondCathetus = Convert.ToDouble(secondCathetus);
			}
			catch (Exception exception)
			{
				Console.WriteLine("Неверно введенны значения сторон."); //Вывод ошибки в консоль.

				_hypotenuse = 0.0;
				_firstCathetus = 0.0;
				_secondCathetus = 0.0;
			}
		}

		public RightTriangle()
		{
			_hypotenuse = 0.0;
			_firstCathetus = 0.0;
			_secondCathetus = 0.0;
		}

		/// <summary>
		/// Вычисление площади прямоугольного треугольника по значениям катетов, установленным в классе.
		/// В случае, если значения не указаны или соотношение сторон не верно возвращает 0.0.
		/// </summary>
		/// <returns></returns>
		public double AreaCalculation()
		{
			if (checkingTheLengthRatio())
				return (_firstCathetus * _secondCathetus) / 2.0;
			else
			{
				Console.WriteLine("Неверное соотношение сторон!");
				return 0.0;
			}
		}

		/// <summary>
		/// Вычисление площади прямоугольного треугольника по значениям катетов, полученным в аргументах.
		/// В случае, если значения не указаны или соотношение сторон не верно возвращает 0.0.
		/// </summary>
		/// <param name="hypotenuse">Значение гипотенузы.</param>
		/// <param name="firstCathetus">Значение первого катета.</param>
		/// <param name="secondCathetus">Значение второго катета.</param>
		/// <returns></returns>
		public double AreaCalculation(object hypotenuse, object firstCathetus, object secondCathetus)
		{
			try
			{
				_hypotenuse = Convert.ToDouble(hypotenuse);
				_firstCathetus = Convert.ToDouble(firstCathetus);
				_secondCathetus = Convert.ToDouble(secondCathetus);
			}
			catch (Exception exc)
			{
				Console.WriteLine("Неверно введенны значения сторон."); //Вывод ошибки в консоль.

				_hypotenuse = 0.0;
				_firstCathetus = 0.0;
				_secondCathetus = 0.0;
			}

			if (checkingTheLengthRatio())
				return (_firstCathetus * _secondCathetus) / 2.0;
			else
			{
				Console.WriteLine("Неверное соотношение сторон!");
				return 0.0;
			}
		}

		/// <summary>
		/// Проверяет правильность соотношения сторон прямоугольного треугольника.
		/// </summary>
		/// <returns>
		/// Возвращает true, если соотношения сторон соответствуют теореме Пифагора, иначе false.
		/// </returns>
		private bool checkingTheLengthRatio()
		{
			if (Math.Pow(_hypotenuse, 2) == Math.Pow(_firstCathetus, 2) + Math.Pow(_secondCathetus, 2)) //Соотношение Пифагора
				return true;
			else
				return false;
		}
	}
}

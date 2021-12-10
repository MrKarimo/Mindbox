using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricCalculator.Figure;
using System;

//Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
//Юнит-тесты
//Легкость добавления других фигур
//Вычисление площади фигуры без знания типа фигуры в compile-time
//Проверку на то, является ли треугольник прямоугольным

//---------------------------------------

//В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий,
//в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
//Также без выполненного задания отклик не будет рассмотрен.
//Github или Pastebin всё еще удобнее чем поле на hh. По возможности — положите ответ рядом с кодом из первого вопроса.

namespace UnitTestGeometric
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalcSquareCircle()
        {
            Figure2D figure = new Circle(2);
            Assert.AreEqual(Math.PI*4, figure.CalcSquare());
        }

        [TestMethod]
        public void CalcSquareTriangle()
        {
            Figure2D figure = new Triangle(3, 4, 5);
            Assert.AreEqual(6, figure.CalcSquare());
        }

        [TestMethod]
        public void IsRightTriangle()
        {
            Triangle figure = new Triangle(3, 4, 5);
            Assert.IsTrue(figure.IsRightAngle);
        }

        [TestMethod]
        public void ZiroParamTriangle()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(0, 4, 5));
        }

        [TestMethod]
        public void ErrorParamTriangle()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(3, 4, 100));
        }
    }
}

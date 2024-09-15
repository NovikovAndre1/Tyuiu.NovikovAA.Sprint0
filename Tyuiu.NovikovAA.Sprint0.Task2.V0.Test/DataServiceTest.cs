namespace Tyuiu.NovikovAA.Sprint0.Task2.V0.Test;
   using Tyuiu.NovikovAA.Sprint0.Task2.V0.Lib;

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Андрей";
            var res = DataService.GetMessage(name);

        // Вызываем класс Assert и метод AreEqual
        Assert.AreEqual("Привет, Андрей", res);
        }
    }

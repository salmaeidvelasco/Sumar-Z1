using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sumar.Controllers;

namespace UnitTestMultiply
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]//No es algo que va a enrutar sino testear
        public void TestMethodMultiply()//Creo un método de Test
        {
            //Arrange
            SumaController multiplyController = new SumaController(); //SumaController clase, el otro nombre en minus lo ponemos como querramoes es el nuevo objeto
            int x = 5;
            int y = 2;
            int espe = 10;
            //Act
            int resultado = multiplyController.Mul(x, y); //multiplyController (objeto de Suma y Mul es el metodo que me comunica controlador con Unittest
            //Assert
            Assert.AreEqual(espe, resultado);

        }
    }
}

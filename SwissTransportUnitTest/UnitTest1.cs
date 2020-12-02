using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwissTransport;
using SwissTransport_Projektarbeit;
using System.Windows.Forms;

namespace SwissTransportUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetStationBoardTest()
        {
            // Arrange
            AbfahrtstafelForm abfahrtstafelFormTest = new AbfahrtstafelForm();
            Transport transportTest = new Transport();

            // Act
            var result = abfahrtstafelFormTest.GetStationBoard("Sursee");
            var expectedResult = transportTest.GetStationBoard("Sursee", "8502007");

            // Assert
            Assert.AreNotEqual(result, expectedResult);
        }
    }
}
